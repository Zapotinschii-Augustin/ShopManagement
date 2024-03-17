using ConsoleApp1.Reflection;

namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.settingsControl = new App.UserControls.SettingsControl();
            this.productsControl = new App.UserControls.ProductsControl();
            this.homeControl = new App.UserControls.HomeControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.ProductsBtn);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 603);
            this.panel1.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(3, 58);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(200, 23);
            this.SettingsBtn.TabIndex = 2;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Location = new System.Drawing.Point(0, 29);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(200, 23);
            this.ProductsBtn.TabIndex = 1;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.UseVisualStyleBackColor = true;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Location = new System.Drawing.Point(0, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(200, 23);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // settingsControl
            // 
            this.settingsControl.Location = new System.Drawing.Point(206, 0);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(777, 600);
            this.settingsControl.TabIndex = 3;
            // 
            // productsControl
            // 
            this.productsControl.Location = new System.Drawing.Point(206, 0);
            this.productsControl.Name = "productsControl";
            this.productsControl.Size = new System.Drawing.Size(777, 600);
            this.productsControl.TabIndex = 2;
            // 
            // homeControl
            // 
            this.homeControl.Location = new System.Drawing.Point(206, 0);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(777, 600);
            this.homeControl.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.settingsControl);
            this.Controls.Add(this.productsControl);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button ProductsBtn;
        private System.Windows.Forms.Button HomeBtn;
        private UserControls.HomeControl homeControl;
        private UserControls.ProductsControl productsControl;
        private UserControls.SettingsControl settingsControl;
    }
}

