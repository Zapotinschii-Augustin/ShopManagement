﻿using ConsoleApp1.Reflection;

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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.BuyProductsBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Label();
            this.ProductsBtn = new System.Windows.Forms.Button();
            this.settingsControl = new App.UserControls.SettingsControl();
            this.createProjectControl = new App.UserControls.createProjectControl();
            this.productsControl = new App.UserControls.ProductsControl();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editProductControl = new App.UserControls.EditProductControl();
            this.shopNameLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(97)))), ((int)(((byte)(250)))));
            this.mainPanel.Controls.Add(this.BuyProductsBtn);
            this.mainPanel.Controls.Add(this.SettingsBtn);
            this.mainPanel.Controls.Add(this.panelHeader);
            this.mainPanel.Controls.Add(this.ProductsBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 687);
            this.mainPanel.TabIndex = 0;
            // 
            // BuyProductsBtn
            // 
            this.BuyProductsBtn.BackColor = System.Drawing.Color.Transparent;
            this.BuyProductsBtn.FlatAppearance.BorderSize = 0;
            this.BuyProductsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BuyProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyProductsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyProductsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuyProductsBtn.Location = new System.Drawing.Point(0, 88);
            this.BuyProductsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.BuyProductsBtn.Name = "BuyProductsBtn";
            this.BuyProductsBtn.Size = new System.Drawing.Size(200, 30);
            this.BuyProductsBtn.TabIndex = 6;
            this.BuyProductsBtn.Text = "&Buy Productts";
            this.BuyProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyProductsBtn.UseVisualStyleBackColor = false;
            this.BuyProductsBtn.Click += new System.EventHandler(this.BuyProductsBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 118);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(200, 30);
            this.SettingsBtn.TabIndex = 5;
            this.SettingsBtn.Text = "&Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.AutoSize = true;
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelHeader.Location = new System.Drawing.Point(3, 18);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(181, 31);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.Text = "Management";
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProductsBtn.FlatAppearance.BorderSize = 0;
            this.ProductsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.ProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsBtn.Location = new System.Drawing.Point(0, 58);
            this.ProductsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Size = new System.Drawing.Size(200, 30);
            this.ProductsBtn.TabIndex = 1;
            this.ProductsBtn.Text = "&Manage Products";
            this.ProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsBtn.UseVisualStyleBackColor = false;
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // settingsControl
            // 
            this.settingsControl.BackColor = System.Drawing.Color.Transparent;
            this.settingsControl.Location = new System.Drawing.Point(202, 58);
            this.settingsControl.MainForm = null;
            this.settingsControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(908, 630);
            this.settingsControl.TabIndex = 7;
            // 
            // createProjectControl
            // 
            this.createProjectControl.Location = new System.Drawing.Point(202, 58);
            this.createProjectControl.MainForm = null;
            this.createProjectControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createProjectControl.Name = "createProjectControl";
            this.createProjectControl.Size = new System.Drawing.Size(908, 630);
            this.createProjectControl.TabIndex = 6;
            // 
            // productsControl
            // 
            this.productsControl.Location = new System.Drawing.Point(202, 58);
            this.productsControl.MainForm = null;
            this.productsControl.ManagementMode = false;
            this.productsControl.Margin = new System.Windows.Forms.Padding(2);
            this.productsControl.Name = "productsControl";
            this.productsControl.Size = new System.Drawing.Size(908, 630);
            this.productsControl.TabIndex = 5;
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(App.MainForm);
            // 
            // editProductControl
            // 
            this.editProductControl.Index = "";
            this.editProductControl.Location = new System.Drawing.Point(202, 58);
            this.editProductControl.MainForm = null;
            this.editProductControl.Name = "editProductControl";
            this.editProductControl.Size = new System.Drawing.Size(908, 630);
            this.editProductControl.TabIndex = 8;
            // 
            // shopNameLabel
            // 
            this.shopNameLabel.AutoSize = true;
            this.shopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNameLabel.Location = new System.Drawing.Point(217, 17);
            this.shopNameLabel.Name = "shopNameLabel";
            this.shopNameLabel.Size = new System.Drawing.Size(121, 31);
            this.shopNameLabel.TabIndex = 9;
            this.shopNameLabel.Text = "Kaufland";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 687);
            this.Controls.Add(this.shopNameLabel);
            this.Controls.Add(this.editProductControl);
            this.Controls.Add(this.settingsControl);
            this.Controls.Add(this.createProjectControl);
            this.Controls.Add(this.productsControl);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private UserControls.ProductsControl productsControl;
        private UserControls.createProjectControl createProjectControl;
        private UserControls.SettingsControl settingsControl;
        private System.Windows.Forms.Label panelHeader;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button ProductsBtn;
        private UserControls.EditProductControl editProductControl;
        private System.Windows.Forms.Label shopNameLabel;
        private System.Windows.Forms.Button BuyProductsBtn;
    }
}

