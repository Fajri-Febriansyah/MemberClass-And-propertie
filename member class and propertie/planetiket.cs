using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace member_class_and_propertie
{
    internal class planetiket
    {
        public string origin { get; set; }
        public string destination { get; set; }
        public int cost { get; set; }
        public string currency { get; set; }

        public void printsummary() 
        {
            Console.WriteLine("================================================");
            Console.WriteLine("ORIGIN                    =    {0}", origin);
            Console.WriteLine("DESTINATION               =    {0}", destination);
            Console.WriteLine("COST                      =    {0}", cost);

            if (currency == "USD")
            {
            Console.WriteLine("CONVERT TO RUPIAH         =    {0}", cost*15000);  
            }
            else if (currency == "IDR")  
            {
            Console.WriteLine("CONVERT TO DOLLAR         =    {0}", cost/15000);   
            }
            Console.WriteLine("================================================");

        }
    }
}
