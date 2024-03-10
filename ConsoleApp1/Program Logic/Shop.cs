using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Program_Logic
{
    internal class Shop
    {
        public Shop() { 
            this.products = new List<Product>();
            this.name = ConfigurationManager.AppSettings.Get("shop_name");
        }

        private readonly List<Product> products;
        private readonly string name;

        public List<Product> Products { 
            get { return products; }
        } 
        public string Name { get { return name; } }

        public void addProduct(string name, int price, string description, ECategory category)
        {
            if (!productIsValid(name, price, category)) return; 

            products.Add(new Product(name, price, description, category));
        }

        public void removeProduct(int index)
        {
            //Show are you sure you want to remove product form;
            products.RemoveAt(index);
        }

        public void changeProduct(ActiveProduct product)
        {
            products[product.Index] = product.product;
        }
        public List<Product> searchProducts(string _name)
        {
            string name = _name.Trim();
            if(name == null || name == "") return products;
            List<Product> searchedProducts = new List<Product>();

            for(int product = 0; product < products.Count; product++)
            {
                if (products[product].Name.Contains(name))
                {
                    searchedProducts.Add(products[product]);
                }
            }

            return searchedProducts;
        }



        static public void logAllProducts(List<Product> products) { 
            for(int product = 0; product < products.Count; product++)
            {
                Console.Write($"name: {products[product].Name} | price: {products[product].Price} | category: {products[product].Category}\ndescription: {products[product].Description}\n");
            }
        }
        private bool productIsValid(string name, int price, ECategory category)
        {
            ProductIsNotValid productIsNotValid = Product.IsValidProduct(name, price, category);
            switch(productIsNotValid)
            {
                case ProductIsNotValid.FALSE: 
                    return true;
                case ProductIsNotValid.price:
                {
                        //Show form with error;
                        return false;
                }
                case ProductIsNotValid.name:
                {
                        //Show form with error;
                        return false;
                }
                case ProductIsNotValid.category:
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
        

    }
}
