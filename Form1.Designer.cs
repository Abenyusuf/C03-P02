namespace WindowsFormsApp1
{
    partial class FruitStand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruitStand));
            this.BananaPriceBox = new System.Windows.Forms.PictureBox();
            this.ApplePriceBox = new System.Windows.Forms.PictureBox();
            this.PearPriceBox = new System.Windows.Forms.PictureBox();
            this.OrangePriceBox = new System.Windows.Forms.PictureBox();
            this.totalbox = new System.Windows.Forms.Label();
            this.TotalOutput = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BananaPriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplePriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PearPriceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangePriceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BananaPriceBox
            // 
            this.BananaPriceBox.Image = ((System.Drawing.Image)(resources.GetObject("BananaPriceBox.Image")));
            this.BananaPriceBox.Location = new System.Drawing.Point(8, 8);
            this.BananaPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.BananaPriceBox.Name = "BananaPriceBox";
            this.BananaPriceBox.Size = new System.Drawing.Size(129, 156);
            this.BananaPriceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BananaPriceBox.TabIndex = 0;
            this.BananaPriceBox.TabStop = false;
            this.BananaPriceBox.Click += new System.EventHandler(this.BananaPriceBox_Click);
            // 
            // ApplePriceBox
            // 
            this.ApplePriceBox.Image = ((System.Drawing.Image)(resources.GetObject("ApplePriceBox.Image")));
            this.ApplePriceBox.Location = new System.Drawing.Point(152, 168);
            this.ApplePriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.ApplePriceBox.Name = "ApplePriceBox";
            this.ApplePriceBox.Size = new System.Drawing.Size(129, 156);
            this.ApplePriceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ApplePriceBox.TabIndex = 1;
            this.ApplePriceBox.TabStop = false;
            this.ApplePriceBox.Click += new System.EventHandler(this.ApplePriceBox_Click);
            // 
            // PearPriceBox
            // 
            this.PearPriceBox.Image = ((System.Drawing.Image)(resources.GetObject("PearPriceBox.Image")));
            this.PearPriceBox.Location = new System.Drawing.Point(152, 8);
            this.PearPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.PearPriceBox.Name = "PearPriceBox";
            this.PearPriceBox.Size = new System.Drawing.Size(129, 156);
            this.PearPriceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PearPriceBox.TabIndex = 2;
            this.PearPriceBox.TabStop = false;
            this.PearPriceBox.Click += new System.EventHandler(this.PearPriceBox_Click);
            // 
            // OrangePriceBox
            // 
            this.OrangePriceBox.Image = ((System.Drawing.Image)(resources.GetObject("OrangePriceBox.Image")));
            this.OrangePriceBox.Location = new System.Drawing.Point(8, 168);
            this.OrangePriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrangePriceBox.Name = "OrangePriceBox";
            this.OrangePriceBox.Size = new System.Drawing.Size(129, 156);
            this.OrangePriceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OrangePriceBox.TabIndex = 3;
            this.OrangePriceBox.TabStop = false;
            this.OrangePriceBox.Click += new System.EventHandler(this.OrangePriceBox_Click);
            // 
            // totalbox
            // 
            this.totalbox.AutoSize = true;
            this.totalbox.Location = new System.Drawing.Point(374, 8);
            this.totalbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalbox.Name = "totalbox";
            this.totalbox.Size = new System.Drawing.Size(31, 13);
            this.totalbox.TabIndex = 4;
            this.totalbox.Text = "Total";
            // 
            // TotalOutput
            // 
            this.TotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalOutput.Location = new System.Drawing.Point(356, 40);
            this.TotalOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalOutput.Name = "TotalOutput";
            this.TotalOutput.Size = new System.Drawing.Size(67, 16);
            this.TotalOutput.TabIndex = 5;
            this.TotalOutput.Text = "$0.00";
            this.TotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(365, 225);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(50, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(365, 271);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FruitStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 326);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TotalOutput);
            this.Controls.Add(this.totalbox);
            this.Controls.Add(this.OrangePriceBox);
            this.Controls.Add(this.PearPriceBox);
            this.Controls.Add(this.ApplePriceBox);
            this.Controls.Add(this.BananaPriceBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FruitStand";
            this.Text = "Fruit Stand";
            ((System.ComponentModel.ISupportInitialize)(this.BananaPriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplePriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PearPriceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrangePriceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BananaPriceBox;
        private System.Windows.Forms.PictureBox ApplePriceBox;
        private System.Windows.Forms.PictureBox PearPriceBox;
        private System.Windows.Forms.PictureBox OrangePriceBox;
        private System.Windows.Forms.Label totalbox;
        private System.Windows.Forms.Label TotalOutput;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

