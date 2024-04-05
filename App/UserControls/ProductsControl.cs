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
        private bool managementMode;
        public bool ManagementMode
        {
            get
            {
                return managementMode;
            }
            set
            {
                managementMode = value;
                if(managementMode)
                {
                    btnCreateProduct.Show();
                } else
                {
                    btnCreateProduct.Hide();
                }
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
            AddDescriptionColumn();
            for (int product = 0; product < MainForm.shop.Products.Count; product++)
            {
                productCards.Add(new ProductLineCard());
                productCards[product].MainForm = this.MainForm;
                productCards[product].Location = new Point(0, (56 + 46 * product));

                productCards[product].ShowButtons = (ManagementMode == true) 
                    ? EActiveButtons.MANAGEMENT
                    : EActiveButtons.CUSTOMERS;

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
                RenderList();
            }
        }

        private void sortByAlphabetChbx_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.shop.searchProducts(inputSearch.InputText, sortByAlphabetChbx.Checked);
            RenderList();
        }
        private void AddDescriptionColumn()
        {
            ProductLineCard columnsDescriptionCard = new ProductLineCard();
            columnsDescriptionCard.Location = new Point(0, 10);
            columnsDescriptionCard._BackgroundColor = Color.Gainsboro;
            columnsDescriptionCard.ShowButtons = EActiveButtons.NONE;
            columnsDescriptionCard.Index = "-1"; // -1 means use standart labels
            columnsDescriptionCard.RefreshSelf();
            this.productsList.Controls.Add(columnsDescriptionCard);
        }
    }
}
