using ConsoleApp1.Program_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UserControls
{
    public partial class createProjectControl : UserControl
    {
        public MainForm MainForm { get; set; }
        public createProjectControl()
        {
            InitializeComponent();
        }
        private void createProjectControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Color.Black, 0, ButtonBorderStyle.Inset,
                                         Color.Black, 1, ButtonBorderStyle.Inset,
                                         Color.Black, 0, ButtonBorderStyle.Inset,
                                         Color.Black, 0, ButtonBorderStyle.Inset);
        }

        private void createProductBtn_Click(object sender, EventArgs e)
        {
            EProductIsNotValid invalidField = MainForm.shop.AddProduct(nameField.InputText, priceField.InputText, descriptionField.InputText, categoryField.InputText);
            showInvalidField(invalidField);
        }
        private void showInvalidField(EProductIsNotValid invalidField)
        {
            switch(invalidField)
            {
                case EProductIsNotValid.FALSE:
                    this.MainForm.ReRenderProductsList();
                    this.MainForm.ElevateUserControl("products");
                    return;
                case EProductIsNotValid.name:

                    return;
                case EProductIsNotValid.price:

                    return;
                case EProductIsNotValid.category:

                    return;
            }
        }
    }
}
