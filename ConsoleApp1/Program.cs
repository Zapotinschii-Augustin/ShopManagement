using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shopName = ConfigurationManager.AppSettings.Get("shop_name");
            Console.WriteLine($"denumirea magazinului: {shopName}");
            Console.ReadKey();
        }
    }
}
