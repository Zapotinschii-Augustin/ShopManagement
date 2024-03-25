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

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string shopName = ConfigurationManager.AppSettings.Get("shop_name");
            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            CShop shop = new CShop();
            AvgDB db = new AvgDB("products");
            db.Clear();

            shop.AddProduct("Pepsi", "4", "2L", "drink");
            shop.AddProduct("Bread", "5", "", "food");
            shop.Products[0].Name = "Cola";
            shop.ChangeProduct(shop.Products[0]);

            shop.searchProducts("");

            Console.WriteLine(shop.Products[0].Name);
            Console.WriteLine(shop.Products[0].Price);
            Console.WriteLine(shop.Products[1].Name, shop.Products[1].Description);
            Console.WriteLine(shop.Products[1].Price);
            Console.ReadKey();
        }
    }
}


//ConsoleApp1.avgDB.ProductsDB db = new ConsoleApp1.avgDB.ProductsDB("db");
//string str = typeof(ConsoleApp1.avgDB.ProductsDB).GetMethod("ProductToString", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(db, new object[] { product }).ToString();


