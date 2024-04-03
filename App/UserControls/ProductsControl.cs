using App.UI_Components;
using ConsoleApp1.Program_Logic;
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
            inputSearch.OnKeyDownCallback = searchInputOnKeyDown;
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

        public void RenderList()
        {
            this.productsList.Controls.Clear();
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
            for (int product = 0; product < MainForm.shop.Products.Count; product++)
            {
                productCards.Add(new ProductLineCard());
                productCards[product].MainForm = this.MainForm;
                productCards[product].Location = new Point(0, (56 + 46 * product));

                productCards[product].ProductName = MainForm.shop.Products[product].Name;
                productCards[product].Description = MainForm.shop.Products[product].Description;
                productCards[product].Price = MainForm.shop.Products[product].Price + " " + MainForm.shop.Currency;
                productCards[product].Category = MainForm.shop.Products[product].Category;

                productCards[product].Index = product.ToString();
                productCards[product].RefreshSelf();
                this.productsList.Controls.Add(productCards[product]);
            }
        }
        private void searchInputOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MainForm.shop.searchProducts(inputSearch.InputText, sortByAlphabetChbx.Checked);
                MainForm.ReRenderProductsList();
            }
        }

        private void sortByAlphabetChbx_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.shop.searchProducts(inputSearch.InputText, sortByAlphabetChbx.Checked);
            MainForm.ReRenderProductsList();
        }
    }
}
