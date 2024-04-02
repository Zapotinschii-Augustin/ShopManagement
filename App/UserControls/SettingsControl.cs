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
    public partial class SettingsControl : UserControl
    {
        public MainForm MainForm { get; set; }
        public SettingsControl()
        {
            InitializeComponent();
            this.shopNameInput.OnKeyDownCallback = shopNameInputOnKeyDown;
            this.currencyInput.OnKeyDownCallback = currencyInputOnKeyDown;
        }

        private void SettingsControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                             Color.Black, 0, ButtonBorderStyle.Inset,
                             Color.Black, 1, ButtonBorderStyle.Inset,
                             Color.Black, 0, ButtonBorderStyle.Inset,
                             Color.Black, 0, ButtonBorderStyle.Inset);
        }

        private void shopNameInputOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Add an Application Setting.
                config.AppSettings.Settings["shop_name"].Value = shopNameInput.InputText;

                // Save the changes in App.config file.
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload of a changed section.
                ConfigurationManager.RefreshSection("appSettings");
                MainForm.shop.Currency = shopNameInput.InputText;
            }
        }

        private void currencyInputOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Add an Application Setting.
                config.AppSettings.Settings["currency"].Value = currencyInput.InputText;

                // Save the changes in App.config file.
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload of a changed section.
                ConfigurationManager.RefreshSection("appSettings");
                MainForm.shop.Currency = currencyInput.InputText;
                MainForm.ReRenderProductsList();
            }
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            shopNameInput.InputText = ConfigurationManager.AppSettings.Get("shop_name");
            currencyInput.InputText = ConfigurationManager.AppSettings.Get("currency");
        }
    }
}
