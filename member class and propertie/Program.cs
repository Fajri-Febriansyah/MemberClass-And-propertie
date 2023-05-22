using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace member_class_and_propertie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            planetiket tiket1 = new planetiket();
            planetiket tiket2 = new planetiket();

            tiket1.origin = "YOGYAKARTA";
            tiket1.destination = "PKU";
            tiket1.cost = 100;
            tiket1.currency = "USD";

            tiket2.origin = "JAKARTA";
            tiket2.destination = "PKU";
            tiket2.cost = 750000;
            tiket2.currency = "USD";

            tiket1.printsummary();
            Console.WriteLine();
            tiket2.printsummary();
        }
    }
}
