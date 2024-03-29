﻿using System.Configuration;
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
        public string Currency { get; set; } = "$";

        public EProductIsNotValid AddProduct(string name, string price, string description, string category)
        {
            EProductIsNotValid productIsNotValid = Product.ProductIsNotValid(name, price, category);
            if (productIsNotValid != EProductIsNotValid.FALSE)
                return productIsNotValid;
            
            Product productToAdd = new Product(name, price, description, category, AvgDB.getNextId(DBNAME));

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
            int index = FindProductIndex(product);
            products[index] = product;
            db.UpdateProduct(product);
        }

        public void searchProducts(string name)
        {
            products = db.getProducts(name);
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
