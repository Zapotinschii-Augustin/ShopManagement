using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Program_Logic
{
    enum ECategory
    {
        NULL = 0,
        food,
        alcohol,
        clothing,
        games,
        pet_supplies,
        health,


        ELSE
    }
    enum ProductIsNotValid
    {
        FALSE = 0,
        name,
        price,
        category
    }

    internal class Product
    {
        private string name;
        private int price;
        private string description;
        private ECategory category; 


        public string Name {
            get { return name; }
            set {
                if (value.Trim() == "") value = "undefined";
                name = value;
            } 
        }
        public int Price {
            get { return price; } 
            set { 
                if(value < 0) value = 0;
                price = value;
            } 
        }
        public string Description { get; set; }
        public ECategory Category { get; set; }
        public Product(string name, int price, string description, ECategory category)
        {
            this.name = name.Trim();
            this.price = price;
            this.description = description;
            this.category = category;
        }
        public static ProductIsNotValid IsValidProduct(string name, int price, ECategory category)
        {
            if (name == null || name.Trim() == "") return ProductIsNotValid.name; //"Name is undefined"
            if (price < 0) return ProductIsNotValid.price; //"Price must be greater than 0"
            if (category == ECategory.NULL) return ProductIsNotValid.category; //"Category not selected"
            return ProductIsNotValid.FALSE;
        }
    }

    internal class ActiveProduct
    {
        private int index;
        public Product product;

        public int Index { get { return index;} }

        public ActiveProduct(int index, Product product)
        {
            this.index = index;
            this.product = product;
        }
    }
}
