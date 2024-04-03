namespace App.UserControls
{
    partial class EditProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.editProductBtn = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryField = new App.UI_Components.InputField();
            this.descriptionField = new App.UI_Components.InputField();
            this.priceField = new App.UI_Components.InputField();
            this.nameField = new App.UI_Components.InputField();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityField = new App.UI_Components.InputField();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(480, 109);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(181, 32);
            this.headerLabel.TabIndex = 19;
            this.headerLabel.Text = "Edit Product";
            // 
            // editProductBtn
            // 
            this.editProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductBtn.Location = new System.Drawing.Point(385, 595);
            this.editProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editProductBtn.Name = "editProductBtn";
            this.editProductBtn.Size = new System.Drawing.Size(392, 66);
            this.editProductBtn.TabIndex = 18;
            this.editProductBtn.Text = "Edit Product";
            this.editProductBtn.UseVisualStyleBackColor = true;
            this.editProductBtn.Click += new System.EventHandler(this.editProductBtn_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(407, 442);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 20);
            this.categoryLabel.TabIndex = 17;
            this.categoryLabel.Text = "Category";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(407, 357);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(95, 20);
            this.descriptionLabel.TabIndex = 16;
            this.descriptionLabel.Text = "Description";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(407, 167);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(407, 261);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Price";
            // 
            // categoryField
            // 
            this.categoryField.InputText = "";
            this.categoryField.inputWidth = 250;
            this.categoryField.Location = new System.Drawing.Point(411, 465);
            this.categoryField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryField.Name = "categoryField";
            this.categoryField.OnKeyDownCallback = null;
            this.categoryField.Placeholder = "Product Category...";
            this.categoryField.PlaceholderColor = System.Drawing.Color.Empty;
            this.categoryField.Size = new System.Drawing.Size(250, 27);
            this.categoryField.TabIndex = 13;
            // 
            // descriptionField
            // 
            this.descriptionField.InputText = "";
            this.descriptionField.inputWidth = 250;
            this.descriptionField.Location = new System.Drawing.Point(411, 380);
            this.descriptionField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.OnKeyDownCallback = null;
            this.descriptionField.Placeholder = "Product Description...";
            this.descriptionField.PlaceholderColor = System.Drawing.Color.Empty;
            this.descriptionField.Size = new System.Drawing.Size(250, 27);
            this.descriptionField.TabIndex = 12;
            // 
            // priceField
            // 
            this.priceField.InputText = "";
            this.priceField.inputWidth = 250;
            this.priceField.Location = new System.Drawing.Point(411, 284);
            this.priceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceField.Name = "priceField";
            this.priceField.OnKeyDownCallback = null;
            this.priceField.Placeholder = "Product Price...";
            this.priceField.PlaceholderColor = System.Drawing.Color.Empty;
            this.priceField.Size = new System.Drawing.Size(250, 27);
            this.priceField.TabIndex = 11;
            // 
            // nameField
            // 
            this.nameField.InputText = "";
            this.nameField.inputWidth = 250;
            this.nameField.Location = new System.Drawing.Point(411, 191);
            this.nameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameField.Name = "nameField";
            this.nameField.OnKeyDownCallback = null;
            this.nameField.Placeholder = "Product Name...";
            this.nameField.PlaceholderColor = System.Drawing.Color.Empty;
            this.nameField.Size = new System.Drawing.Size(250, 27);
            this.nameField.TabIndex = 10;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(407, 517);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(71, 20);
            this.quantityLabel.TabIndex = 21;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityField
            // 
            this.quantityField.InputText = "";
            this.quantityField.inputWidth = 250;
            this.quantityField.Location = new System.Drawing.Point(411, 540);
            this.quantityField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityField.Name = "quantityField";
            this.quantityField.OnKeyDownCallback = null;
            this.quantityField.Placeholder = "Product Quantity..";
            this.quantityField.PlaceholderColor = System.Drawing.Color.Empty;
            this.quantityField.Size = new System.Drawing.Size(250, 27);
            this.quantityField.TabIndex = 20;
            // 
            // EditProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityField);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.editProductBtn);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryField);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.nameField);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditProductControl";
            this.Size = new System.Drawing.Size(1211, 775);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EditProductControl_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button editProductBtn;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private UI_Components.InputField categoryField;
        private UI_Components.InputField descriptionField;
        private UI_Components.InputField priceField;
        private UI_Components.InputField nameField;
        private System.Windows.Forms.Label quantityLabel;
        private UI_Components.InputField quantityField;
    }
}
