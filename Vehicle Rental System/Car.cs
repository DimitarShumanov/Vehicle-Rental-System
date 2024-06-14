using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public class Car: Vehicle
    {
        public int SafetyRating { get; set; }

        public override double CalculateRentalCost()
        {
            double dailyCost = RentalPeriod <= 7 ? 20 : 15;
            return dailyCost * RentalPeriod;
        }

        public override double CalculateInsuranceCost()
        {
            double insuranceCost = (0.01 / 100) * Price * RentalPeriod;
            InitialInsurancePerDay = (0.01 / 100) * Price;
            if (SafetyRating == 4 || SafetyRating == 5)
            {
                insuranceCost /= 0.9;
                InsuranceDiscountPerDay = InitialInsurancePerDay * 0.01;
            }
            return insuranceCost;
        }
    }
}
