namespace App.UserControls
{
    partial class createProjectControl
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryField = new App.UI_Components.InputField();
            this.descriptionField = new App.UI_Components.InputField();
            this.priceField = new App.UI_Components.InputField();
            this.nameField = new App.UI_Components.InputField();
            this.createProductBtn = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityField = new App.UI_Components.InputField();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(397, 287);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 20);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(397, 193);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(397, 383);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(95, 20);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(397, 468);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 20);
            this.categoryLabel.TabIndex = 7;
            this.categoryLabel.Text = "Category";
            // 
            // categoryField
            // 
            this.categoryField.InputText = "";
            this.categoryField.inputWidth = 250;
            this.categoryField.Location = new System.Drawing.Point(401, 491);
            this.categoryField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryField.Name = "categoryField";
            this.categoryField.OnKeyDownCallback = null;
            this.categoryField.Placeholder = "Product Category...";
            this.categoryField.PlaceholderColor = System.Drawing.Color.Empty;
            this.categoryField.Size = new System.Drawing.Size(333, 33);
            this.categoryField.TabIndex = 3;
            // 
            // descriptionField
            // 
            this.descriptionField.InputText = "";
            this.descriptionField.inputWidth = 250;
            this.descriptionField.Location = new System.Drawing.Point(401, 406);
            this.descriptionField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.OnKeyDownCallback = null;
            this.descriptionField.Placeholder = "Product Description...";
            this.descriptionField.PlaceholderColor = System.Drawing.Color.Empty;
            this.descriptionField.Size = new System.Drawing.Size(333, 33);
            this.descriptionField.TabIndex = 2;
            // 
            // priceField
            // 
            this.priceField.InputText = "";
            this.priceField.inputWidth = 250;
            this.priceField.Location = new System.Drawing.Point(401, 310);
            this.priceField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceField.Name = "priceField";
            this.priceField.OnKeyDownCallback = null;
            this.priceField.Placeholder = "Product Price...";
            this.priceField.PlaceholderColor = System.Drawing.Color.Empty;
            this.priceField.Size = new System.Drawing.Size(333, 33);
            this.priceField.TabIndex = 1;
            // 
            // nameField
            // 
            this.nameField.InputText = "";
            this.nameField.inputWidth = 250;
            this.nameField.Location = new System.Drawing.Point(401, 217);
            this.nameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameField.Name = "nameField";
            this.nameField.OnKeyDownCallback = null;
            this.nameField.Placeholder = "Product Name...";
            this.nameField.PlaceholderColor = System.Drawing.Color.Empty;
            this.nameField.Size = new System.Drawing.Size(333, 33);
            this.nameField.TabIndex = 0;
            // 
            // createProductBtn
            // 
            this.createProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProductBtn.Location = new System.Drawing.Point(374, 627);
            this.createProductBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createProductBtn.Name = "createProductBtn";
            this.createProductBtn.Size = new System.Drawing.Size(392, 66);
            this.createProductBtn.TabIndex = 8;
            this.createProductBtn.Text = "Create Product";
            this.createProductBtn.UseVisualStyleBackColor = true;
            this.createProductBtn.Click += new System.EventHandler(this.createProductBtn_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(451, 133);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(218, 32);
            this.headerLabel.TabIndex = 9;
            this.headerLabel.Text = "Create Product";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(397, 550);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(71, 20);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityField
            // 
            this.quantityField.InputText = "";
            this.quantityField.inputWidth = 250;
            this.quantityField.Location = new System.Drawing.Point(401, 573);
            this.quantityField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityField.Name = "quantityField";
            this.quantityField.OnKeyDownCallback = null;
            this.quantityField.Placeholder = "Product Quantity..";
            this.quantityField.PlaceholderColor = System.Drawing.Color.Empty;
            this.quantityField.Size = new System.Drawing.Size(250, 27);
            this.quantityField.TabIndex = 10;
            // 
            // createProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.quantityField);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.createProductBtn);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryField);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.nameField);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "createProjectControl";
            this.Size = new System.Drawing.Size(1211, 775);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.createProjectControl_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI_Components.InputField nameField;
        private UI_Components.InputField priceField;
        private UI_Components.InputField descriptionField;
        private UI_Components.InputField categoryField;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button createProductBtn;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label quantityLabel;
        private UI_Components.InputField quantityField;
    }
}
