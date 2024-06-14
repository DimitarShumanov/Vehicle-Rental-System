using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car { Brand = "Mitsubishi", Model = "Miage", Price = 15000, RentalPeriod = 10, SafetyRating = 3 };
            Vehicle motorcycle = new Motorcycle { Brand = "Triumph Tiger", Model = "Sport 660", Price = 10000, RentalPeriod = 10, RiderAge = 20 };
            Vehicle cargoVan = new CargoVan { Brand = "Citroen", Model = "Jumper", Price = 20000, RentalPeriod = 15, DriverExperience = 8 };

            Renter renter1 = new Renter("Jone Doe", new DateTime(2024, 6, 3), new DateTime(2024, 6, 13), new DateTime(2024, 6, 13), car, 10);

            Renter renter2 = new Renter("Mary Johnson", new DateTime(2024, 6, 3), new DateTime(2024, 6, 13), new DateTime(2024, 6, 13), motorcycle, 10);

            Renter renter3 = new Renter("John Markson", new DateTime(2024, 6, 3), new DateTime(2024, 6, 18), new DateTime(2024, 6, 13), cargoVan, 10);

            Invoice invoice = new Invoice();
            invoice.AddRental(renter1);
            invoice.AddRental(renter2);
            invoice.AddRental(renter3);

            invoice.PrintInvoice();

            Console.ReadKey();
        }
    }
}
