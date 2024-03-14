using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Reflection
{
    internal class TypeAnalyzer
    {
        public void UpdateValue(string propertyName, string value)
        {
            PropertyInfo property = this.GetType().GetProperty(propertyName);

            if (property == null)
            {
                throw new Exception($"Property '{propertyName}' does not exist in type {GetType().Name}.");
            }

            property.SetValue(this, value);
        }

        public string GetValue(string propertyName)
        {
            PropertyInfo property = GetType().GetProperty(propertyName);

            if (property == null)
            {
                throw new Exception($"Property '{propertyName}' does not exist in type {GetType().Name}.");
            }

            object value = property.GetValue(this);
            return value.ToString();
        }
    }
}
