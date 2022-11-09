using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;  // read/write to files
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;  // Translater to binary
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thomas_CourseProject_part2
{
    public partial class MainForm : Form
    {
        // form level references
        const string FILENAME = "Employees.dat";
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Add item to employee listbox
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // See if input form was cancelled
                if (result == DialogResult.Cancel)
                    return; // end since cancelled

                // get user input and create employee object
                string fName = frmInput.FirstNameTextBox.Text;
                string lName = frmInput.LastNameTextBox.Text;
                string ssn = frmInput.SSNTextBox.Text;
                string date = frmInput.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.HealthInsuranceTextBox.Text;
                double lifeIns = Double.Parse(frmInput.LifeInsuranceTextBox.Text);
                int vacation = Int32.Parse(frmInput.VacationTextBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                Employee emp;
                if(frmInput.HourlyRadioButton.Checked)
                {
                    // Get Child Items
                    float hourlyRate = float.Parse(frmInput.Pay1TextBox.Text);
                    float hoursWorked = float.Parse(frmInput.Pay2TextBox.Text);

                    // Polymorphism
                    emp = new Hourly(fName, lName, ssn, hireDate, benefits, hourlyRate, hoursWorked);
                }
                else if(frmInput.SalaryRadioButton.Checked)
                {
                    // Get Child Items
                    double salary = Double.Parse(frmInput.Pay1TextBox.Text);

                    // Polymorphism
                    emp = new Salary(fName, lName, ssn, hireDate, benefits, salary);
                }
                else
                {
                    MessageBox.Show("Error. Invalid Employee Type.");
                    return;     // end method since we have an error
                }

                // Add object to ListBox
                EmployeesListBox.Items.Add(emp);

                // Write all employees to the file:
                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            // Convert Listbox items to a generic list
            List<Employee> empList = new List<Employee>();

            foreach (Employee emp in EmployeesListBox.Items)
            {
                empList.Add(emp);
            }

            // Open a pipe to the file and create a translator
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            // Write the generic list to the file
            formatter.Serialize(fs, empList);

            // Close the pipe
            fs.Close();

            // Tell user records are written to the file
            MessageBox.Show("Employees were written to the file");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Remove item from employee listbox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if( itemNumber > -1 )
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);

                // Write all employee objects to file
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please select employee to remove.");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            // Clear the listbox
            EmployeesListBox.Items.Clear();

            // Read all Employee objects from file
            ReadEmpsFromFile();

        }

        private void ReadEmpsFromFile()
        {
            // Check to see if the file exists
            if(File.Exists(FILENAME) && new FileInfo(FILENAME).Length > 0)
            {
                // Create a pipe from the file and create the translator
                FileStream fs = new FileStream(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                // Read all Employee objects from file:
                List<Employee> empList = (List<Employee>)formatter.Deserialize(fs);

                // Copy the Employee objects into the listbox
                foreach(Employee emp in empList)
                {
                    EmployeesListBox.Items.Add(emp);
                }
                
                // Close the pipe
                fs.Close();
            }
        }

        private void PrintPaychecksButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing paychecks for all employees...");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load employees from file
            ReadEmpsFromFile();
        }

        /*private void EmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        private void EmployeesListBox_DoubleClick(object sender, EventArgs e)
        {
            // Edit selected employee in the listbox
            InputForm frmUpdate = new InputForm();

            using(frmUpdate)
            {
                frmUpdate.Text = "Employee Update Form";
                frmUpdate.SubmitButton.Text = "Update";

                int itemNumber = EmployeesListBox.SelectedIndex;

                if(itemNumber < 0)
                {
                    MessageBox.Show("Error. Invalid Employee.");
                    return;
                }

                Employee emp = (Employee)EmployeesListBox.Items[itemNumber];

                frmUpdate.FirstNameTextBox.Text = emp.FirstName;
                frmUpdate.LastNameTextBox.Text = emp.LastName;
                frmUpdate.SSNTextBox.Text = emp.SSN;
                frmUpdate.HireDateTextBox.Text = emp.HireDate.ToShortDateString();
                frmUpdate.HealthInsuranceTextBox.Text = emp.BenefitsPackage.HealthInsurance;
                frmUpdate.LifeInsuranceTextBox.Text = emp.BenefitsPackage.LifeInsurance.ToString("C2");
                frmUpdate.VacationTextBox.Text = emp.BenefitsPackage.VacationDays.ToString();

                if(emp is Hourly)
                {
                    Hourly hrly = (Hourly)emp;
                    frmUpdate.HourlyRadioButton.Checked = true;
                    frmUpdate.Pay1TextBox.Text = hrly.HourlyRate.ToString("N2");
                    frmUpdate.Pay2TextBox.Text = hrly.HoursWorked.ToString("F1");
                }
                else if(emp is Salary)
                {
                    Salary sal = (Salary)emp;
                    frmUpdate.SalaryRadioButton.Checked = true;
                    frmUpdate.Pay1TextBox.Text = sal.AnnualSalary.ToString("N2");
                }

                DialogResult result = frmUpdate.ShowDialog();

                if (result == DialogResult.Cancel)
                    return; // end the method since user canceled update

                EmployeesListBox.Items.RemoveAt(itemNumber);

                // Get user's updated input and create an Employee object
                string fName = frmUpdate.FirstNameTextBox.Text;
                string lName = frmUpdate.LastNameTextBox.Text;
                string ssn = frmUpdate.SSNTextBox.Text;
                string date = frmUpdate.HireDateTextBox.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmUpdate.HealthInsuranceTextBox.Text;
                // Pull a substring that does not contain the initial '$' sign
                string lifeInsString = frmUpdate.LifeInsuranceTextBox.Text;
                lifeInsString = lifeInsString.Substring(1);
                double lifeIns = Double.Parse(lifeInsString);
                int vacationDays = Int32.Parse(frmUpdate.VacationTextBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacationDays);

                if(frmUpdate.HourlyRadioButton.Checked)
                {
                    float rate = float.Parse(frmUpdate.Pay1TextBox.Text);
                    float hours = float.Parse(frmUpdate.Pay2TextBox.Text);
                    emp = new Hourly(fName, lName, ssn, hireDate, benefits, rate, hours);
                }
                else if(frmUpdate.SalaryRadioButton.Checked)
                {
                    double salary = Double.Parse(frmUpdate.Pay1TextBox.Text);
                    emp = new Salary(fName, lName, ssn, hireDate, benefits, salary);
                }

                // Add the updated Employee object to the employees listbox
                EmployeesListBox.Items.Add(emp);

                // Write all update Employee objects to the file
                WriteEmpsToFile();
            }
        }
    }
}
