using App.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI_Components
{
    public partial class ProductLineCard : UserControl
    {
        public MainForm MainForm { get; set; }
        private readonly ToolTip ToolTip1 = new ToolTip();
        public Color _BackgroundColor { get; set; } = Colors.productCardLineBG;
        public string Index { get; set; }
        public bool HideButtons { 
            set {
                if(value)
                {
                    this.deleteBtn.Hide();
                    this.editBtn.Hide();
                } else
                {
                    this.deleteBtn.Show();
                    this.editBtn.Show();
                }
            } 
        }

        public ProductLineCard()
        {
            InitializeComponent();
            RefreshSelf();
        }

        private void ProductLineCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Color.Green, 1, ButtonBorderStyle.Solid,
                                         Colors.mainBorder, 1, ButtonBorderStyle.Solid,
                                         Colors.mainBorder, 1, ButtonBorderStyle.Solid,
                                         Colors.mainBorder, 1, ButtonBorderStyle.Solid);
        }
        public void RefreshSelf()
        {
            this.BackColor = _BackgroundColor;
            if(Index != null && Int32.Parse(Index) != -1)
            {
                this.nameLabel.Text = MainForm.shop.Products[Int32.Parse(Index)].Name;
                this.priceLabel.Text = MainForm.shop.Products[Int32.Parse(Index)].Price;
                this.categoryLabel.Text = MainForm.shop.Products[Int32.Parse(Index)].Category;
                this.descriptionLabel.Text = "Description";
                this.quantityLabel.Text = MainForm.shop.Products[Int32.Parse(Index)].Quantity;
                ToolTip1.SetToolTip(descriptionPanel, MainForm.shop.Products[Int32.Parse(Index)].Description);
                ToolTip1.SetToolTip(descriptionLabel, MainForm.shop.Products[Int32.Parse(Index)].Description);
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            AcceptForm acceptForm = new AcceptForm();
            acceptForm.productToDelete = this.ProductName;
            acceptForm.ShowDialog();
            if(AcceptForm.Accepted)
            {
                MainForm.shop.RemoveProduct(MainForm.shop.Products[Int32.Parse(Index)]);
                this.MainForm.ReRenderProductsList();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
                this.MainForm.changeEditProductControlIndex(this.Index);
                this.MainForm.ElevateUserControl("editProduct");
        }
    }
}
