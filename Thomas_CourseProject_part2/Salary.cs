using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomas_CourseProject_part2
{
    [Serializable]
    class Salary : Employee
    {
        // Attributes
        private double annualSalary;

        // Constructors
        public Salary() : base()
        {
            annualSalary = 0.0;
        }
        public Salary(string firstName, string lastName, string ssn, 
            DateTime hireDate, Benefits benefits, double annualSalary) 
            : base(firstName, lastName, ssn, hireDate, benefits)
        {
            AnnualSalary = annualSalary;
        }

        // Behaviors
        public override string ToString()
        {
            return base.ToString() + ", Salary: " + annualSalary.ToString("C2");
        }

        public override double CalculatePay()
        {
            return annualSalary / 26.0;
        }

        // Properties
        public double AnnualSalary
        {
            get { return annualSalary; }
            set
            {
                if(value > 0.0 && value <= 1000000)
                    annualSalary = value;
                else
                    annualSalary = 0.0;
            }
        }
    }
}
