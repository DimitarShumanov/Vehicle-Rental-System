using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public class Motorcycle : Vehicle
    {
        public int RiderAge { get; set; }

        public override double CalculateRentalCost()
        {
            double dailyCost = RentalPeriod <= 7 ? 15 : 10;
            return dailyCost * RentalPeriod;
        }

        public override double CalculateInsuranceCost()
        {
            double insuranceCost = (0.02 / 100) * Price * RentalPeriod;
            InitialInsurancePerDay = (0.02 / 100) * Price;
            if (RiderAge < 25)
            {
                insuranceCost *= 1.2;
                InsuranceAdditionPerDay = InitialInsurancePerDay * 0.2;
            }
            return insuranceCost;
        }
    }
}
