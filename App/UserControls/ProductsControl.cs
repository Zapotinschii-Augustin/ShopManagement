using App.UI_Components;
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
    public partial class ProductsControl : UserControl
    {
        private List<ProductLineCard> productCards = new List<ProductLineCard>(); 
        public MainForm MainForm { get; set; }
        public ProductsControl()
        {
            InitializeComponent();
            inputSearch.Placeholder = "Search products";
            inputSearch.PlaceholderColor = ColorTranslator.FromHtml("#4F4B4A");
            inputSearch.inputWidth = 199;
            RenderList();
        }

        private void ProductsControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                             Color.Black, 0, ButtonBorderStyle.Inset,
                             Color.Black, 1, ButtonBorderStyle.Inset,
                             Color.Black, 0, ButtonBorderStyle.Inset,
                             Color.Black, 0, ButtonBorderStyle.Inset);
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            this.MainForm.ElevateUserControl("createProject");
        }

        private void RenderList()
        {
            for(int product = 0; product < 20; product++)
            {
                productCards.Add(new ProductLineCard());
                productCards[product].Location = new Point(0, (10+46 * product));
                productCards[product].ProductName = "Name";
                productCards[product].Description = "Description";
                productCards[product].Price = "Price";
                productCards[product].Category = "Category";
                productCards[product].RefreshSelf();
                this.productsList.Controls.Add(productCards[product]);
            }
        }
    }
}
