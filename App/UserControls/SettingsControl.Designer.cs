namespace App.UserControls
{
    partial class SettingsControl
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
            this.shopNameLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.currencyInput = new App.UI_Components.InputField();
            this.shopNameInput = new App.UI_Components.InputField();
            this.SuspendLayout();
            // 
            // shopNameLabel
            // 
            this.shopNameLabel.AutoSize = true;
            this.shopNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNameLabel.Location = new System.Drawing.Point(37, 33);
            this.shopNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shopNameLabel.Name = "shopNameLabel";
            this.shopNameLabel.Size = new System.Drawing.Size(103, 20);
            this.shopNameLabel.TabIndex = 0;
            this.shopNameLabel.Text = "Shop name: ";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel.Location = new System.Drawing.Point(37, 84);
            this.currencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(87, 20);
            this.currencyLabel.TabIndex = 2;
            this.currencyLabel.Text = "Currency: ";
            // 
            // currencyInput
            // 
            this.currencyInput.InputText = "";
            this.currencyInput.inputWidth = 250;
            this.currencyInput.Location = new System.Drawing.Point(153, 84);
            this.currencyInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currencyInput.Name = "currencyInput";
            this.currencyInput.OnKeyDownCallback = null;
            this.currencyInput.Placeholder = null;
            this.currencyInput.PlaceholderColor = System.Drawing.Color.Empty;
            this.currencyInput.Size = new System.Drawing.Size(250, 27);
            this.currencyInput.TabIndex = 3;
            // 
            // shopNameInput
            // 
            this.shopNameInput.InputText = "";
            this.shopNameInput.inputWidth = 250;
            this.shopNameInput.Location = new System.Drawing.Point(153, 33);
            this.shopNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shopNameInput.Name = "shopNameInput";
            this.shopNameInput.OnKeyDownCallback = null;
            this.shopNameInput.Placeholder = null;
            this.shopNameInput.PlaceholderColor = System.Drawing.Color.Empty;
            this.shopNameInput.Size = new System.Drawing.Size(250, 27);
            this.shopNameInput.TabIndex = 1;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currencyInput);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.shopNameInput);
            this.Controls.Add(this.shopNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(1211, 775);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsControl_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopNameLabel;
        private UI_Components.InputField shopNameInput;
        private UI_Components.InputField currencyInput;
        private System.Windows.Forms.Label currencyLabel;
    }
}
