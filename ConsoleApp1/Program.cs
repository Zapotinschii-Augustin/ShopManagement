using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Program_Logic;
using System.Reflection;
using System.IO;

using CShop = ConsoleApp1.Program_Logic.Shop;
using System.Xml.Linq;
using ConsoleApp1.avgDB;
using System.Security.Cryptography;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string shopName = ConfigurationManager.AppSettings.Get("shop_name");
            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            CShop shop = new CShop("Profi");
            AvgDB db = new AvgDB("products");

            shop.searchProducts("");

            for(int product = 0; product < shop.Products.Count; product++)
            {
                Console.WriteLine($"Name: {shop.Products[product].Name}, Quantity: {shop.Products[product].Quantity}\n");
            }
            Console.ReadKey();
        }
    }
}


//ConsoleApp1.avgDB.ProductsDB db = new ConsoleApp1.avgDB.ProductsDB("db");
//string str = typeof(ConsoleApp1.avgDB.ProductsDB).GetMethod("ProductToString", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(db, new object[] { product }).ToString();


