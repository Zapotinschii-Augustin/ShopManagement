using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Program_Logic;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shopName = ConfigurationManager.AppSettings.Get("shop_name");
            
            Console.WriteLine(Product.IsValidProduct("name", 10, ECategory.games));
            Console.WriteLine(shopName);

            Console.ReadKey();
        }
    }
}
