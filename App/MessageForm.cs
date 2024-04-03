using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MessageForm : Form
    {
        public string Message { 
            get {
                return messageLabel.Text;
            } 
            set { 
                messageLabel.Text = value;
            } 
        }
        public MessageForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
