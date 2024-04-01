using App.UI_Components;
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
    public partial class ProductsControl : UserControl
    {
        private List<ProductLineCard> productCards = new List<ProductLineCard>(); 
        private MainForm mainForm;
        public MainForm MainForm {
            get { return mainForm; }
            set
            {
                mainForm = value;
                RenderList();
            }        
        }
        public ProductsControl()
        {
            InitializeComponent();
            inputSearch.Placeholder = "Search products";
            inputSearch.PlaceholderColor = ColorTranslator.FromHtml("#4F4B4A");
            inputSearch.inputWidth = 199;
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
            ProductLineCard columnsDescriptionCard = new ProductLineCard();
            columnsDescriptionCard.Location = new Point(0, 10);
            columnsDescriptionCard.ProductName = "NAME";
            columnsDescriptionCard.DescriptionLabelText = "SHOW";
            columnsDescriptionCard.Price = "PRICE";
            columnsDescriptionCard.Category = "CATEGORY";
            columnsDescriptionCard._BackgroundColor = Color.Gainsboro;
            columnsDescriptionCard.HideButtons = true;
            columnsDescriptionCard.RefreshSelf();
            this.productsList.Controls.Add(columnsDescriptionCard);
            for (int product = 0; product < 20; product++)
            {
                productCards.Add(new ProductLineCard());
                productCards[product].MainForm = this.MainForm;
                productCards[product].Location = new Point(0, (56 + 46 * product));

                productCards[product].ProductName = "Name";
                productCards[product].Description = "Description";
                productCards[product].Price = "Price" + MainForm.shop.Currency;
                productCards[product].Category = "Category";

                productCards[product].Index = "index";
                productCards[product].RefreshSelf();
                this.productsList.Controls.Add(productCards[product]);
            }
        }
    }
}
