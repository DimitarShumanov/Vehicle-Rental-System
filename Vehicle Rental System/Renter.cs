using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public class Renter
    {
        public string CustomerName { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public Vehicle Vehicle { get; set; }
        public int DaysRented { get; set; }

        public Renter(string customerName, DateTime reservationStartDate, DateTime reservationEndDate, DateTime actualReturnDate, Vehicle vehicle, int daysRented)
        {
            CustomerName = customerName;
            ReservationStartDate = reservationStartDate;
            ReservationEndDate = reservationEndDate;
            ActualReturnDate = actualReturnDate;
            Vehicle = vehicle;
            DaysRented = daysRented;
        }

        public double CalculateAdjustedRentalCost(Vehicle vehicle, int daysRented)
        {
            double fullPriceDays = daysRented;
            double halfPriceDays = vehicle.RentalPeriod - daysRented;
            double dailyCost = vehicle.CalculateRentalCost() / vehicle.RentalPeriod;

            return (fullPriceDays * dailyCost) + (halfPriceDays * dailyCost / 2);
        }

        public double CalculateAdjustedInsuranceCost(Vehicle vehicle, int daysRented)
        {
            return vehicle.CalculateInsuranceCost() * daysRented / vehicle.RentalPeriod;
        }

        public void PrintRentalDetails()
        {
            double rentalCost = CalculateAdjustedRentalCost(Vehicle, DaysRented);
            double insuranceCost = CalculateAdjustedInsuranceCost(Vehicle, DaysRented);
            double initialInsuranceCost = Vehicle.InitialInsurancePerDay;
            double insuranceAddition = Vehicle.InsuranceAdditionPerDay;
            double insuranceDiscount = Vehicle.InsuranceDiscountPerDay;

            Console.WriteLine("XXXXXXXXXXXX");
            Console.WriteLine($"Date: {DateTime.Now:yyyy-MM-dd}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine();
            Console.WriteLine($"Rented Vehicle: {Vehicle.Brand} {Vehicle.Model}");
            Console.WriteLine();
            Console.WriteLine($"Reservation start date: {ReservationStartDate:yyyy-MM-dd}");
            Console.WriteLine($"Reservation end date: {ReservationEndDate:yyyy-MM-dd}");
            Console.WriteLine($"Reserved rental days: {Vehicle.RentalPeriod} days");
            Console.WriteLine();
            Console.WriteLine($"Actual return date: {ActualReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Actual rental days: {DaysRented} days");
            Console.WriteLine();
            Console.WriteLine($"Rental cost per day: ${Vehicle.CalculateRentalCost() / Vehicle.RentalPeriod:F2}");
            if (insuranceDiscount > 0 || insuranceAddition > 0) 
            {
                Console.WriteLine($"Initial insurance per day: ${initialInsuranceCost:F2}");
                if(insuranceDiscount > 0)
                {
                    Console.WriteLine($"Insurance discount per day: ${insuranceDiscount:F2}");
                }
                if(insuranceAddition > 0)
                {
                    Console.WriteLine($"Insurance addition per day: ${insuranceAddition:F2}");
                }
            }
            Console.WriteLine($"Insurance per day: ${insuranceCost / DaysRented:F2}");
            if(Vehicle.RentalPeriod - DaysRented > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Early return discount for rent: ${(Vehicle.CalculateRentalCost() / Vehicle.RentalPeriod) * (Vehicle.RentalPeriod - DaysRented) / 2:F2}");
                Console.WriteLine($"Early return discount for insurance: ${insuranceDiscount * (Vehicle.RentalPeriod - DaysRented):F2}");
            }
            Console.WriteLine();
            Console.WriteLine($"Total rent: ${rentalCost:F2}");
            Console.WriteLine($"Total Insurance: ${insuranceCost:F2}");
            Console.WriteLine($"Total: ${rentalCost + insuranceCost:F2}");
            Console.WriteLine("XXXXXXXXXXXX");
        }
    }
}
