
namespace Cars_Dealership_DBProject
{
    partial class Welcome
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
            this.Admin_button = new System.Windows.Forms.Button();
            this.Buyer_button = new System.Windows.Forms.Button();
            this.Seller_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin_button
            // 
            this.Admin_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Admin_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Admin_button.Font = new System.Drawing.Font("Sitka Small", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Admin_button.Location = new System.Drawing.Point(421, 12);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(188, 60);
            this.Admin_button.TabIndex = 1;
            this.Admin_button.Text = "Admin";
            this.Admin_button.UseVisualStyleBackColor = false;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // Buyer_button
            // 
            this.Buyer_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Buyer_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buyer_button.Font = new System.Drawing.Font("Sitka Small", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buyer_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Buyer_button.Location = new System.Drawing.Point(51, 397);
            this.Buyer_button.Name = "Buyer_button";
            this.Buyer_button.Size = new System.Drawing.Size(237, 56);
            this.Buyer_button.TabIndex = 4;
            this.Buyer_button.Text = "Buyer / Renter";
            this.Buyer_button.UseVisualStyleBackColor = false;
            this.Buyer_button.Click += new System.EventHandler(this.Buyer_button_Click);
            // 
            // Seller_button
            // 
            this.Seller_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Seller_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Seller_button.Font = new System.Drawing.Font("Sitka Small", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Seller_button.Location = new System.Drawing.Point(771, 397);
            this.Seller_button.Name = "Seller_button";
            this.Seller_button.Size = new System.Drawing.Size(237, 56);
            this.Seller_button.TabIndex = 5;
            this.Seller_button.Text = "Seller";
            this.Seller_button.UseVisualStyleBackColor = false;
            this.Seller_button.Click += new System.EventHandler(this.Seller_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Cars_Dealership_DBProject.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(974, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1060, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Admin_button);
            this.Controls.Add(this.Seller_button);
            this.Controls.Add(this.Buyer_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Button Buyer_button;
        private System.Windows.Forms.Button Seller_button;
        private System.Windows.Forms.Button button1;
    }
}

