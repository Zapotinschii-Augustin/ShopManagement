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
        public MainForm MainForm { get; set; }
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
    }
}
