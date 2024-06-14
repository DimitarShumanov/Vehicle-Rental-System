using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public abstract class Vehicle
    {
        public string Brand { get ; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int RentalPeriod { get; set; }

        public double InitialInsurancePerDay { get; set; }
        public double InsuranceAdditionPerDay { get; set; }
        public double InsuranceDiscountPerDay { get; set; }

        public abstract double CalculateRentalCost();
        public abstract double CalculateInsuranceCost();
    }
}
