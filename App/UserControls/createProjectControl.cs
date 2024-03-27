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
    public partial class createProjectControl : UserControl
    {
        public createProjectControl()
        {
            InitializeComponent();
        }

        private void createProjectControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Color.Black, 0, ButtonBorderStyle.Inset,
                                         Color.Black, 1, ButtonBorderStyle.Inset,
                                         Color.Black, 0, ButtonBorderStyle.Inset,
                                         Color.Black, 0, ButtonBorderStyle.Inset);
        }
    }
}
