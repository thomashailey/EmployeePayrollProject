using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomas_CourseProject_part2
{
    [Serializable]
    public class Employee
    {
        // attributes
        protected string firstName;
        protected string lastName;
        protected string ssn;
        protected DateTime hireDate;
        protected Benefits benefits;

        // constructors
        public Employee()
        {
            firstName = "N/A";
            lastName = "N/A";
            ssn = "N/A";
            hireDate = new DateTime();
            BenefitsPackage = new Benefits();
        }

        public Employee(string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
            BenefitsPackage = benefits;
        }

        // behaviors
        public override string ToString()
        {
            // return "firstName = " + firstName + ", lastName = " + lastName + ", ssn = " + ssn + ", hireDate = " + hireDate.ToShortDateString();
            return firstName + " "+ lastName + ", " + ssn + ", " + hireDate.ToShortDateString();
        }

        public virtual double CalculatePay()
        {
            return 0.0;
        }

        // properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }



        public Benefits BenefitsPackage
        {
            get { return benefits; }
            set { this.benefits = value; }
        }
    }
}
