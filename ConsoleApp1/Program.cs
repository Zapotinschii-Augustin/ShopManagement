using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Program_Logic;

using CShop = ConsoleApp1.Program_Logic.Shop;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string shopName = ConfigurationManager.AppSettings.Get("shop_name");
            CShop shop = new CShop();
            shop.addProduct("pasta",10,"so good",ECategory.food);
            shop.addProduct("papito", 100, "so smart", ECategory.pet_supplies);
            shop.addProduct("pizza", 40, "40 cm", ECategory.food);

            CShop.logAllProducts(shop.searchProducts("pi"));

            Console.ReadKey();
        }
    }
}
