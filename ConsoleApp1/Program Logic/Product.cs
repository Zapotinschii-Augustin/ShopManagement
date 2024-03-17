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
        category
    }

    public class Product : TypeAnalyzer
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ID { get; set; }


        public Product() { }
        public Product(string name, string price, string description, string category, string id = null)
        {
            this.Name = name.Trim();
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.ID = (id == null ? (Convert.ToUInt32(AvgDB.getLastId(Shop.DBNAME)) + 1).ToString() : id);
        }

        public static EProductIsNotValid ProductIsNotValid(string name, string price, string category)
        {
            if (name == null || name.Trim() == "") return EProductIsNotValid.name; //"Name is undefined"
            if (Convert.ToInt32(price) < 0) return EProductIsNotValid.price; //"Price must be greater than 0"
            if (category == String.Empty) return EProductIsNotValid.category; //"Category not selected"
            return EProductIsNotValid.FALSE;
        }
    }
}
