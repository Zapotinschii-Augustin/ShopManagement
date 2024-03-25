using App.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App.UI_Components
{
    public partial class InputField : UserControl
    {
        private string placeholder;
        public string Placeholder { 
            get { return placeholder; } 
            set {
                placeholder = value;
                Input.Text = placeholder;
            } }
        public Color PlaceholderColor { get; set; }
        public int inputWidth { get; set; } = 250;
        private string inputText = "";
        public string InputText { get { return inputText; } }
        public InputField()
        {
            InitializeComponent();
            Input.ForeColor = PlaceholderColor;
            Input.Text = Placeholder;
        }

        private void Input_Leave(object sender, EventArgs e)
        {
            inputText = Input.Text;
            if (Input.Text.Length == 0 || Input.Text == String.Empty)
            {
                Input.Text = Placeholder;
                Input.ForeColor = PlaceholderColor;
            }
        }

        private void Input_Enter(object sender, EventArgs e)
        {
            Input.Text = inputText;
            Input.ForeColor = Colors.fontAlpha;
        }

        private void InputField_Load(object sender, EventArgs e)
        {
            Input.Width = inputWidth;
            this.Width = inputWidth;
            this.Height = Input.Height;
        }
    }
}
