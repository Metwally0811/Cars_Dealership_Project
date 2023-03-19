
namespace Cars_Dealership_DBProject.Seller
{
    partial class SellerFunctionalities
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
            this.ApproveCar_button = new System.Windows.Forms.Button();
            this.EditCarInfo_button = new System.Windows.Forms.Button();
            this.OfferNewCar_button = new System.Windows.Forms.Button();
            this.RemoveCar_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApproveCar_button
            // 
            this.ApproveCar_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ApproveCar_button.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveCar_button.ForeColor = System.Drawing.SystemColors.Info;
            this.ApproveCar_button.Location = new System.Drawing.Point(119, 471);
            this.ApproveCar_button.Name = "ApproveCar_button";
            this.ApproveCar_button.Size = new System.Drawing.Size(320, 70);
            this.ApproveCar_button.TabIndex = 13;
            this.ApproveCar_button.Text = "View Cars Sold Before";
            this.ApproveCar_button.UseVisualStyleBackColor = false;
            this.ApproveCar_button.Click += new System.EventHandler(this.ApproveCar_button_Click);
            // 
            // EditCarInfo_button
            // 
            this.EditCarInfo_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EditCarInfo_button.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCarInfo_button.ForeColor = System.Drawing.SystemColors.Info;
            this.EditCarInfo_button.Location = new System.Drawing.Point(119, 196);
            this.EditCarInfo_button.Name = "EditCarInfo_button";
            this.EditCarInfo_button.Size = new System.Drawing.Size(320, 70);
            this.EditCarInfo_button.TabIndex = 12;
            this.EditCarInfo_button.Text = "Edit Car Info";
            this.EditCarInfo_button.UseVisualStyleBackColor = false;
            this.EditCarInfo_button.Click += new System.EventHandler(this.EditCarInfo_button_Click);
            // 
            // OfferNewCar_button
            // 
            this.OfferNewCar_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OfferNewCar_button.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfferNewCar_button.ForeColor = System.Drawing.SystemColors.Info;
            this.OfferNewCar_button.Location = new System.Drawing.Point(119, 63);
            this.OfferNewCar_button.Name = "OfferNewCar_button";
            this.OfferNewCar_button.Size = new System.Drawing.Size(320, 70);
            this.OfferNewCar_button.TabIndex = 11;
            this.OfferNewCar_button.Text = "Offer New Car";
            this.OfferNewCar_button.UseVisualStyleBackColor = false;
            this.OfferNewCar_button.Click += new System.EventHandler(this.OfferNewCar_button_Click);
            // 
            // RemoveCar_button
            // 
            this.RemoveCar_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveCar_button.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCar_button.ForeColor = System.Drawing.SystemColors.Info;
            this.RemoveCar_button.Location = new System.Drawing.Point(119, 333);
            this.RemoveCar_button.Name = "RemoveCar_button";
            this.RemoveCar_button.Size = new System.Drawing.Size(320, 70);
            this.RemoveCar_button.TabIndex = 14;
            this.RemoveCar_button.Text = "Remove Car";
            this.RemoveCar_button.UseVisualStyleBackColor = false;
            this.RemoveCar_button.Click += new System.EventHandler(this.RemoveCar_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back_button.Location = new System.Drawing.Point(409, 570);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(138, 38);
            this.Back_button.TabIndex = 17;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // SellerFunctionalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 624);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.RemoveCar_button);
            this.Controls.Add(this.ApproveCar_button);
            this.Controls.Add(this.EditCarInfo_button);
            this.Controls.Add(this.OfferNewCar_button);
            this.Name = "SellerFunctionalities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerFunctionalities";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ApproveCar_button;
        private System.Windows.Forms.Button EditCarInfo_button;
        private System.Windows.Forms.Button OfferNewCar_button;
        private System.Windows.Forms.Button RemoveCar_button;
        private System.Windows.Forms.Button Back_button;
    }
}