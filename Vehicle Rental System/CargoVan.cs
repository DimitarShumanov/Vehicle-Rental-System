using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public class CargoVan : Vehicle
    {
        public int DriverExperience { get; set; }

        public override double CalculateRentalCost()
        {
            double dailyCost = RentalPeriod <= 7 ? 50 : 40;
            return dailyCost * RentalPeriod;
        }

        public override double CalculateInsuranceCost()
        {
            double insuranceCost = (0.03 / 100) * Price * RentalPeriod;
            InitialInsurancePerDay = (0.03 / 100) * Price;
            Console.WriteLine(DriverExperience);
            if (DriverExperience > 5)
            {
                insuranceCost *= 0.85;
                InsuranceDiscountPerDay = InitialInsurancePerDay * 0.15;
            }
            return insuranceCost;
        }
    }
}
