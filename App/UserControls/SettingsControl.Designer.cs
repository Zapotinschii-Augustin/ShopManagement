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
            this.shopNameLabel.Location = new System.Drawing.Point(28, 27);
            this.shopNameLabel.Name = "shopNameLabel";
            this.shopNameLabel.Size = new System.Drawing.Size(82, 16);
            this.shopNameLabel.TabIndex = 0;
            this.shopNameLabel.Text = "Shop name: ";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLabel.Location = new System.Drawing.Point(28, 68);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(82, 16);
            this.currencyLabel.TabIndex = 2;
            this.currencyLabel.Text = "Shop name: ";
            // 
            // currencyInput
            // 
            this.currencyInput.OnKeyDownCallback = null;
            this.currencyInput.inputWidth = 250;
            this.currencyInput.Location = new System.Drawing.Point(115, 68);
            this.currencyInput.Margin = new System.Windows.Forms.Padding(2);
            this.currencyInput.Name = "currencyInput";
            this.currencyInput.Placeholder = null;
            this.currencyInput.PlaceholderColor = System.Drawing.Color.Empty;
            this.currencyInput.Size = new System.Drawing.Size(250, 23);
            this.currencyInput.TabIndex = 3;
            // 
            // shopNameInput
            // 
            this.shopNameInput.OnKeyDownCallback = null;
            this.shopNameInput.inputWidth = 250;
            this.shopNameInput.Location = new System.Drawing.Point(115, 27);
            this.shopNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.shopNameInput.Name = "shopNameInput";
            this.shopNameInput.Placeholder = null;
            this.shopNameInput.PlaceholderColor = System.Drawing.Color.Empty;
            this.shopNameInput.Size = new System.Drawing.Size(250, 23);
            this.shopNameInput.TabIndex = 1;
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currencyInput);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.shopNameInput);
            this.Controls.Add(this.shopNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(908, 630);
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
