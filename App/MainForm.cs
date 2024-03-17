using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1.Reflection;

namespace App
{
    public partial class MainForm : Form
    {
        private readonly string[] controls = { "products", "home", "settings" };
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void ElevateUserControl(string userControlName)
        {
            Type userControl = typeof(UserControl);
            MethodInfo method = userControl.GetMethod("Hide");
            FieldInfo controlProperty;

            for (int control = 0; control < controls.Length; control++)
            {
                controlProperty = GetType().GetField(controls[control] + "Control", BindingFlags.NonPublic | BindingFlags.Instance);
                method.Invoke(controlProperty.GetValue(this), new object[] { });
            }

            controlProperty = GetType().GetField(userControlName + "Control", BindingFlags.NonPublic | BindingFlags.Instance);
            method = userControl.GetMethod("Show");
            method.Invoke(controlProperty.GetValue(this), new object[] { });
            method = userControl.GetMethod("BringToFront");
            method.Invoke(controlProperty.GetValue(this), new object[] { });
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ElevateUserControl("home");
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            ElevateUserControl("products");
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            ElevateUserControl("settings");
        }
    }
}
