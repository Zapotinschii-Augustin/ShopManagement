using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Variables;
using CShop = ConsoleApp1.Program_Logic.Shop;

namespace App
{
    enum EActiveControl
    {
        products = 0,
        settings
    }
    //source control: mainPanel (mainPanel.ResetBindings())
    public partial class MainForm : Form
    {
        private readonly string[] controls = { "products", "createProject", "settings", "editProduct" };
        EActiveControl activeControl;
        public static CShop shop = new CShop( ConfigurationManager.AppSettings.Get("shop_name"), ConfigurationManager.AppSettings.Get("currency") );

        public MainForm()
        {
            InitializeComponent();
            SettingsBtn.FlatAppearance.MouseOverBackColor = Colors.hoverBeta;
            ProductsBtn.FlatAppearance.MouseOverBackColor = Colors.hoverBeta;
            productsControl.MainForm = this;
            productsControl.BringToFront();
            activeControl = EActiveControl.products;
            ResetBtns();
        }

        public void ElevateUserControl(string userControlName)
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
        private void ResetBtns()
        {
            ProductsBtn.BackColor = Color.Transparent;
            SettingsBtn.BackColor = Color.Transparent;
            switch(activeControl)
            {
                case EActiveControl.products:
                    ProductsBtn.BackColor = Colors.activeBtn;
                    return;
                case EActiveControl.settings:
                    SettingsBtn.BackColor = Colors.activeBtn;
                    return;
            }
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            ElevateUserControl("products");
            activeControl = EActiveControl.products;
            ResetBtns();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            ElevateUserControl("settings");
            activeControl = EActiveControl.settings;
            ResetBtns();
        }

        public void changeEditProductControlIndex(string index)
        {
            editProductControl.Index = index;
        }
    }
}
