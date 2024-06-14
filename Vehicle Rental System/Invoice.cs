using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    public class Invoice
    {
        private List<Renter> Renters { get; set; }

        public Invoice()
        {
            Renters = new List<Renter>();
        }

        public void AddRental(Renter renter)
        {
            Renters.Add(renter);
        }

        public void PrintInvoice()
        {
            foreach (var renter in Renters)
            {
                renter.PrintRentalDetails();
                Console.WriteLine();
            }
        }
    }
}
