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
using App.Variables;

namespace App
{
    enum EActiveControl
    {
        products = 0,
        home,
        settings
    }
    //source control: mainPanel (mainPanel.ResetBindings())
    public partial class MainForm : Form
    {
        private readonly string[] controls = { "products", "home", "settings" };
        EActiveControl activeControl;

        public MainForm()
        {
            InitializeComponent();
            mainPanel.BackColor = Colors.Beta;
            this.BackColor = Colors.Alpha;
            SettingsBtn.FlatAppearance.MouseOverBackColor = Colors.hoverBeta;
            HomeBtn.FlatAppearance.MouseOverBackColor = Colors.hoverBeta;
            ProductsBtn.FlatAppearance.MouseOverBackColor = Colors.hoverBeta;
            homeControl.BringToFront();
            activeControl = EActiveControl.home;
            ResetBtns();
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
        private void ResetBtns()
        {
            HomeBtn.BackColor = Color.Transparent;
            ProductsBtn.BackColor = Color.Transparent;
            SettingsBtn.BackColor = Color.Transparent;
            switch(activeControl)
            {
                case EActiveControl.home:
                    HomeBtn.BackColor = Colors.activeBtn;
                    return;
                case EActiveControl.products:
                    ProductsBtn.BackColor = Colors.activeBtn;
                    return;
                case EActiveControl.settings:
                    SettingsBtn.BackColor = Colors.activeBtn;
                    return;
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ElevateUserControl("home");
            activeControl = EActiveControl.home;
            ResetBtns();
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
    }
}
