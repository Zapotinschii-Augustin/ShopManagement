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
        private ToolTip ToolTip1 = new ToolTip();
        public Color _BackgroundColor { get; set; } = Colors.productCardLineBG;
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string DescriptionLabelText { get; set; } = "Description";
        public string Category { get; set; }
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
            this.nameLabel.Text = ProductName;
            this.priceLabel.Text = Price;
            this.categoryLabel.Text = Category;
            this.descriptionLabel.Text = DescriptionLabelText;
            ToolTip1.SetToolTip(descriptionPanel, Description);
            ToolTip1.SetToolTip(descriptionLabel, Description);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            AcceptForm acceptForm = new AcceptForm();
            acceptForm.productToDelete = this.ProductName;
            acceptForm.ShowDialog();
            if(AcceptForm.Accepted)
            {
                //Delete product
                return;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
                this.MainForm.changeEditProductControlIndex("0");
                this.MainForm.ElevateUserControl("editProduct");
        }
    }
}
