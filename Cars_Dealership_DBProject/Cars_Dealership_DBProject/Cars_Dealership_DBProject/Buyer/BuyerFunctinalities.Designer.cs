
namespace Cars_Dealership_DBProject.Buyer
{
    partial class BuyerFunctinalities
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
            this.ViewPastTrans_button = new System.Windows.Forms.Button();
            this.Rent_button = new System.Windows.Forms.Button();
            this.Buy_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewPastTrans_button
            // 
            this.ViewPastTrans_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ViewPastTrans_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPastTrans_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ViewPastTrans_button.Location = new System.Drawing.Point(120, 343);
            this.ViewPastTrans_button.Name = "ViewPastTrans_button";
            this.ViewPastTrans_button.Size = new System.Drawing.Size(266, 70);
            this.ViewPastTrans_button.TabIndex = 18;
            this.ViewPastTrans_button.Text = "View Past Transactions";
            this.ViewPastTrans_button.UseVisualStyleBackColor = false;
            this.ViewPastTrans_button.Click += new System.EventHandler(this.ViewPastTrans_button_Click);
            // 
            // Rent_button
            // 
            this.Rent_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Rent_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Rent_button.Location = new System.Drawing.Point(120, 206);
            this.Rent_button.Name = "Rent_button";
            this.Rent_button.Size = new System.Drawing.Size(266, 70);
            this.Rent_button.TabIndex = 16;
            this.Rent_button.Text = "Rent";
            this.Rent_button.UseVisualStyleBackColor = false;
            this.Rent_button.Click += new System.EventHandler(this.Rent_button_Click);
            // 
            // Buy_button
            // 
            this.Buy_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Buy_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Buy_button.Location = new System.Drawing.Point(120, 81);
            this.Buy_button.Name = "Buy_button";
            this.Buy_button.Size = new System.Drawing.Size(266, 63);
            this.Buy_button.TabIndex = 15;
            this.Buy_button.Text = "Buy";
            this.Buy_button.UseVisualStyleBackColor = false;
            this.Buy_button.Click += new System.EventHandler(this.Buy_button_Click);
            // 
            // BuyerFunctinalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 481);
            this.Controls.Add(this.ViewPastTrans_button);
            this.Controls.Add(this.Rent_button);
            this.Controls.Add(this.Buy_button);
            this.Name = "BuyerFunctinalities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyerFunctinalities";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewPastTrans_button;
        private System.Windows.Forms.Button Rent_button;
        private System.Windows.Forms.Button Buy_button;
    }
}