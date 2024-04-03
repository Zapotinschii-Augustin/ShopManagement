namespace App.UserControls
{
    partial class ProductsControl
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
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.sortByAlphabetChbx = new System.Windows.Forms.CheckBox();
            this.productsList = new App.UI_Components.ProductsList();
            this.inputSearch = new App.UI_Components.InputField();
            this.SuspendLayout();
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(97)))), ((int)(((byte)(250)))));
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProduct.ForeColor = System.Drawing.Color.White;
            this.btnCreateProduct.Location = new System.Drawing.Point(30, 16);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(172, 32);
            this.btnCreateProduct.TabIndex = 3;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // sortByAlphabetChbx
            // 
            this.sortByAlphabetChbx.AutoSize = true;
            this.sortByAlphabetChbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByAlphabetChbx.Location = new System.Drawing.Point(539, 28);
            this.sortByAlphabetChbx.Name = "sortByAlphabetChbx";
            this.sortByAlphabetChbx.Size = new System.Drawing.Size(134, 20);
            this.sortByAlphabetChbx.TabIndex = 5;
            this.sortByAlphabetChbx.Text = "Sort By Alphabete";
            this.sortByAlphabetChbx.UseVisualStyleBackColor = true;
            this.sortByAlphabetChbx.CheckedChanged += new System.EventHandler(this.sortByAlphabetChbx_CheckedChanged);
            // 
            // productsList
            // 
            this.productsList.AutoScroll = true;
            this.productsList.Location = new System.Drawing.Point(30, 63);
            this.productsList.Margin = new System.Windows.Forms.Padding(4);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(847, 580);
            this.productsList.TabIndex = 4;
            // 
            // inputSearch
            // 
            this.inputSearch.InputText = "";
            this.inputSearch.inputWidth = 250;
            this.inputSearch.Location = new System.Drawing.Point(678, 25);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(2);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.OnKeyDownCallback = null;
            this.inputSearch.Placeholder = null;
            this.inputSearch.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.inputSearch.Size = new System.Drawing.Size(250, 23);
            this.inputSearch.TabIndex = 2;
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sortByAlphabetChbx);
            this.Controls.Add(this.productsList);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.inputSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(908, 630);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductsControl_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UI_Components.InputField inputSearch;
        private System.Windows.Forms.Button btnCreateProduct;
        private UI_Components.ProductsList productsList;
        private System.Windows.Forms.CheckBox sortByAlphabetChbx;
    }
}
