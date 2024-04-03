using ConsoleApp1.avgDB;
using ConsoleApp1.Reflection;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Program_Logic
{
    public enum EProductIsNotValid
    {
        FALSE = 0,
        name,
        price,
        category,
        quantity
    }

    public class Product : TypeAnalyzer
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Quantity { get; set; } = "0";
        public string ID { get; set; }


        public Product() { }
        public Product(string name, string price, string description, string category, string quantity, string id = null)
        {
            this.Name = name.Trim();
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.Quantity = quantity;
            this.ID = id;
        }

        public static EProductIsNotValid ProductIsNotValid(string name, string price, string category, string quantity)
        {
            if (name == null || name.Trim() == "") return EProductIsNotValid.name; //"Name is undefined"
            if (price == null || Convert.ToDouble(price) < 0) return EProductIsNotValid.price; //"Price must be greater than 0"
            if (category == String.Empty || category == null) return EProductIsNotValid.category; //"Category not selected"
            if (quantity == null || quantity == String.Empty || Convert.ToDouble(quantity) < 0) return EProductIsNotValid.quantity;
            return EProductIsNotValid.FALSE;
        }
    }
}
