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
        public Color _BackgroundColor { get; set; } = Colors.productCardLineBG;
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Index { get; set; }

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
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(descriptionPanel, Description);
            this.nameLabel.Text = ProductName;
            this.priceLabel.Text = Price;
            this.categoryLabel.Text = Category;
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
    }
}
