using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thomas_CourseProject_part2
{
    [Serializable]
    public class Benefits
    {
        // Attributes
        private string healthInsurance;
        private double lifeInsurance;
        public int vacationDays;

        // Constructors
        public Benefits()
        {
            healthInsurance = "unknown";
            lifeInsurance = 0.0;
            vacationDays = 0;
        }
        public Benefits(string healthInsurance, double lifeInsurance, int vacationDays)
        {
            this.HealthInsurance = healthInsurance;
            this.LifeInsurance = lifeInsurance;
            this.VacationDays = vacationDays;
        }

        // Behaviors
        public override string ToString()
        {
            return "HealthInsurance: "+ healthInsurance + ", LifeInsurance: "+ lifeInsurance
                + ", VacationDays: "+ vacationDays;
        }
        // Properties
        public string HealthInsurance
        {
            get { return healthInsurance; }
            set
            {
                if (value.Length > 0)
                    healthInsurance = value;
                else
                    healthInsurance = "unknown";
            }
        }
        public double LifeInsurance
        {
            get { return lifeInsurance; }
            set
            {
                if (value >= 0.0 && value <= 1000000.0)
                    lifeInsurance = value;
                else
                    lifeInsurance = 0.0;
            }
        }
        public int VacationDays
        {
            get { return vacationDays; }
            set
            {
                if (value > 0 && value < 40)
                    vacationDays = value;
                else
                    lifeInsurance = 0;
            }
        }
    }
}
