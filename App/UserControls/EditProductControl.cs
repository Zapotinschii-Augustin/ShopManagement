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
        private string index;
        public string Index { 
            get {
                return index;
            }
            set { 
                this.index = value;
                //change inputs
            }
        }
        public EditProductControl()
        {
            InitializeComponent();
        }

        private void editProductBtn_Click(object sender, EventArgs e)
        {

        }




        private void EditProductControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Color.Black, 0, ButtonBorderStyle.Inset,
                                         Color.Black, 1, ButtonBorderStyle.Inset,
                                         Color.Black, 0, ButtonBorderStyle.Inset,
                                         Color.Black, 0, ButtonBorderStyle.Inset);
        }
    }
}
