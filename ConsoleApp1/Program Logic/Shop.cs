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

//You can use list of products on your UI, no need for aditional array;
namespace ConsoleApp1.Program_Logic
{
    public class Shop
    {
        public Shop() {
            this.name = ConfigurationManager.AppSettings.Get("shop_name");
            this.db = new ProductsDB(DBNAME);
            products = db.getProducts();
        }

        private List<Product> products;
        private readonly string name;
        private ProductsDB db;
        public static readonly string DBNAME = "products";

        public List<Product> Products { get { return products; } }
        public string Name { get { return name; } }

        public EProductIsNotValid AddProduct(string name, string price, string description, string category)
        {
            if (Product.ProductIsNotValid(name, price, category) != EProductIsNotValid.FALSE)
                return Product.ProductIsNotValid(name, price, category);
            
            Product productToAdd = new Product(name, price, description, category);

            products.Add(productToAdd);
            db.addProduct(productToAdd);
            return EProductIsNotValid.FALSE;
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

        public void searchProducts(string name)
        {
            products = db.getProducts(name);
        }
        static public void LogAllProducts(List<Product> products) {
            for (int product = 0; product < products.Count; product++)
            {
                Console.Write($"name: {products[product].Name} | price: {products[product].Price} | category: {products[product].Category}\ndescription: {products[product].Description}\n");
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
