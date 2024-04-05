using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class BuyProductForm : Form
    {
        public MainForm MainForm { get; set; }
        public string Index { get; set; }
        public BuyProductForm()
        {
            InitializeComponent();
            this.quantityInput.OnKeyDownCallback = quantityInputOnKeyDown;
            this.quantityInput.InputText = "1";
            this.quantityInput.Focus();
        }

        private void quantityInputOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!ValidateInput()) return;

                MainForm.shop.Products[Convert.ToInt32(Index)].Quantity = Convert.ToInt32(MainForm.shop.Products[Convert.ToInt32(Index)].Quantity) - Convert.ToInt32(quantityInput.InputText) + "";
                MainForm.shop.ChangeProduct(MainForm.shop.Products[Convert.ToInt32(Index)]);
                MainForm.ReRenderProductsList();
                this.Hide();
            }
        }

        private bool ValidateInput()
        {
            if (quantityInput.InputText == String.Empty)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.Message = "Number of products field cant be empty";
                messageForm.ShowDialog();
                quantityInput.InputText = "1";
                quantityInput.Focus();
                return false;
            } else if(Convert.ToInt32(quantityInput.InputText) <= 0)
            {
                MessageForm messageForm = new MessageForm();
                messageForm.Message = "Number of products should be more then 1";
                messageForm.ShowDialog();
                quantityInput.InputText = "1";
                quantityInput.Focus();
                return false;
            } else if (Convert.ToInt32(quantityInput.InputText) > Convert.ToInt32(MainForm.shop.Products[Convert.ToInt32(Index)].Quantity))
            {
                MessageForm messageForm = new MessageForm();
                messageForm.Message = $"Product quantity: {MainForm.shop.Products[Convert.ToInt32(Index)].Quantity}";
                messageForm.ShowDialog();
                quantityInput.InputText = "1";
                quantityInput.Focus();
                return false;
            }
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
