using ConsoleApp1.Program_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ConsoleApp1.avgDB
{
    //note that avgDB cant work without ID
    public class AvgDB
    {
        public AvgDB(string DBName)
        {
            this.DBPath = AppDomain.CurrentDomain.BaseDirectory + DBName + ".txt";

            if (!File.Exists(DBPath))
            {
                File.Create(DBPath).Close();
            }
        }

        public static readonly char DELIM = '~';

        virtual public void Clear()
        {
            File.WriteAllText(DBPath, "");
        }
        protected string DBPath { get; set; }

 
        protected void addRow(string row)
        {
            StreamWriter file = File.AppendText(DBPath);
            file.Write(row + "\n");
            file.Close();
        }

        protected void updateRow(string updatedRow)
        {
            try
            {
                string[] rows = File.ReadAllLines(DBPath);
                List<string> newRows = new List<string>();

                foreach (string row in rows)
                {
                    if (updatedRow.Split(DELIM)[0] != row.Split(DELIM)[0]) //id of row
                    {
                        newRows.Add(row);
                    }
                }
                newRows.Add(updatedRow);

                File.WriteAllLines(DBPath, newRows);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected string[] getAllRows()
        {
            return File.ReadAllLines(DBPath);
        }

        protected void deleteById(string id)
        {
            try
            {
                string[] rows = File.ReadAllLines(DBPath);
                List<string> newRows = new List<string>();

                foreach (string row in rows)
                {
                    if (id != row.Split(DELIM)[0]) //id of row
                    {
                        newRows.Add(row);
                    }
                }

                File.WriteAllLines(DBPath, newRows);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public static string getNextId(string DBName)
        {
            string[] rows = File.ReadAllLines($"{DBName}.txt");

            if (rows.Length == 0) return "0";

            return (Convert.ToInt32(rows[rows.Length - 1].Split(DELIM)[0]) + 1).ToString();
        }
    }


    //first column of DBs build on AvgDB must be ID column;
    public class ProductsDB : AvgDB
    {
        public ProductsDB(string DBName) : base(DBName) { }
        
        private List<string> DBColumns = new List<string>() {"ID", "Name", "Price", "Description", "Category", "Quantity"};


        public void addProduct(Product product)
        {
            addRow(ProductToString(product));   
        }

        public void UpdateProduct(Product product)
        {
            updateRow(ProductToString(product));
        }

        public List<Product> getProducts(string name = "")
        {
            //collect rows from db and make Products
            List<Product> productsToReturn = new List<Product>();
            string[] products = getAllRows();
            Product productToAdd;

            foreach (string product in products)
            {
                productToAdd = StringToProduct(product);
                if(productToAdd.Name.Contains(name))
                {
                    productsToReturn.Add(productToAdd);
                }
            }

            return productsToReturn;
        }

        public void removeProduct(Product product)
        {
            deleteById(product.ID);
        }

        private string ProductToString(Product product) {
            string str = String.Empty;
            foreach(string column in DBColumns) 
            { 
                str += product.GetValue(column) + DELIM; 
            }

            str = str.Remove(str.Length - 1, 1);

            return str;
        }

        private Product StringToProduct(string str)
        {
            Product product = new Product();
            string[] values = str.Split(DELIM);

            for(int column = 0; column < values.Length; column++)
            {
                product.UpdateValue(DBColumns[column], values[column]);
            }

            return product;
        }
    }
}
