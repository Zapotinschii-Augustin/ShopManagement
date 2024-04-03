using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AvgDB = ConsoleApp1.avgDB.AvgDB;
using ConsoleApp1.avgDB;

//You can use list of products on your UI, no need for aditional array;
namespace ConsoleApp1.Program_Logic
{
    public class Shop
    {
        public Shop(string name, string currency = "$") {
            this.Name = name;
            this.Currency = currency;
            this.db = new ProductsDB(DBNAME);
            products = db.getProducts();
        }

        private List<Product> products;
        private ProductsDB db;
        
        public static readonly string DBNAME = "products";

        public List<Product> Products { get { return products; } }
        public string Name { get; set; }
        public string Currency { get; set; }

        public EProductIsNotValid AddProduct(string name, string price, string description, string category, string quantity)
        {
            EProductIsNotValid productIsNotValid = Product.ProductIsNotValid(name, price, category, quantity);
            if (productIsNotValid != EProductIsNotValid.FALSE)
                return productIsNotValid;
            
            Product productToAdd = new Product(name, price, description, category, quantity, AvgDB.getNextId(DBNAME));

            products.Add(productToAdd);
            db.addProduct(productToAdd);
            return EProductIsNotValid.FALSE;
        }

        public void RemoveProduct(Product product)
        {
            int index = FindProductIndex(product);
            db.removeProduct(product);
            products.RemoveAt(index);
        }

        public void ChangeProduct(Product product)
        {
            db.UpdateProduct(product);
            db.getProducts();
        }

        public void searchProducts(string name, bool sort = false)
        {
            products = db.getProducts(name);
            if(sort)
            {
                products = products.OrderBy(x => x.Name).ToList();
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
