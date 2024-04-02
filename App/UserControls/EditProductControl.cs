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
    public partial class EditProductControl : UserControl
    {
        public MainForm MainForm { get; set; }
        private string index;
        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                this.index = value;
                
                if(index != string.Empty)
                {
                  nameField.InputText = MainForm.shop.Products[Int32.Parse(index)].Name;
                  priceField.InputText = MainForm.shop.Products[Int32.Parse(index)].Price;
                  descriptionField.InputText = MainForm.shop.Products[Int32.Parse(index)].Description;
                  categoryField.InputText = MainForm.shop.Products[Int32.Parse(index)].Category;
                }
            }
        }
        public EditProductControl()
        {
            InitializeComponent();
        }

        private void editProductBtn_Click(object sender, EventArgs e)
        {
            EProductIsNotValid invalidField = Product.ProductIsNotValid(nameField.InputText, priceField.InputText, categoryField.InputText);
            if(invalidField == EProductIsNotValid.FALSE)
            {
                MainForm.shop.Products[Int32.Parse(index)].Name = nameField.InputText;
                MainForm.shop.Products[Int32.Parse(index)].Price = priceField.InputText;
                MainForm.shop.Products[Int32.Parse(index)].Description = descriptionField.InputText;
                MainForm.shop.Products[Int32.Parse(index)].Category = categoryField.InputText;

                MainForm.shop.ChangeProduct(MainForm.shop.Products[Int32.Parse(Index)]);
            }
            showInvalidField(invalidField);
        }

        private void EditProductControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Color.Black, 0, ButtonBorderStyle.Inset,
                                         Color.Black, 1, ButtonBorderStyle.Inset,
                                         Color.Black, 0, ButtonBorderStyle.Inset,
                                         Color.Black, 0, ButtonBorderStyle.Inset);
        }

        private void showInvalidField(EProductIsNotValid invalidField)
        {
            switch (invalidField)
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
