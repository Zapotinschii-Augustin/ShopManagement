using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AvgDB = ConsoleApp1.avgDB.AvgDB;
using ConsoleApp1.avgDB;
using System.IO;

//remove array producs, not necesary, getProducts will get products directly from db;
//when update, add, remove products from UI, UI array will change;
namespace ConsoleApp1.Program_Logic
{
    internal class Shop
    {
        public Shop() {
            this.name = ConfigurationManager.AppSettings.Get("shop_name");
            this.db = new ProductsDB(DBNAME);
            products = db.getProducts();
        }

        private readonly List<Product> products;
        private readonly string name;
        private ProductsDB db;
        public static readonly string DBNAME = "products";

        public List<Product> Products { get { return products; } }

        public string Name { get { return name; } }

        public void AddProduct(string name, string price, string description, string category)
        {
            if (!IsProductValid(name, price, category)) return;
            Product productToAdd = new Product(name, price, description, category);

            products.Add(productToAdd);
            db.addProduct(productToAdd);
        }

        public void RemoveProduct(Product product)
        {
            int index = FindProductIndex(product);
            //Show are you sure you want to remove product form;
            db.removeProduct(product);
            products.RemoveAt(index);
        }

        public void ChangeProduct(Product product)
        {
            int index = FindProductIndex(product);
            products[index] = product;
            db.UpdateProduct(product);
        }

        static public void LogAllProducts(List<Product> products) {
            for (int product = 0; product < products.Count; product++)
            {
                Console.Write($"name: {products[product].Name} | price: {products[product].Price} | category: {products[product].Category}\ndescription: {products[product].Description}\n");
            }
        }
        private bool IsProductValid(string name, string price, string category)
        {
            EProductIsNotValid productIsNotValid = Product.ProductIsNotValid(name, price, category);
            switch (productIsNotValid)
            {
                case EProductIsNotValid.FALSE:
                    return true;
                case EProductIsNotValid.price:
                    {
                        //Show form with error;
                        return false;
                    }
                case EProductIsNotValid.name:
                    {
                        //Show form with error;
                        return false;
                    }
                case EProductIsNotValid.category:
                    {
                        //Show form with error;
                        return false;
                    }
                default:
                    {
                        //Show undefined error
                        return false;
                    }
            }
        }
        private int FindProductIndex(Product product) {
            for(int index = 0; index < products.Count; index++)
            {
                if (products[index].ID == product.ID) return index;
            }
            return -1;
        }

    }
}
