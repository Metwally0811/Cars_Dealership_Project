
namespace Cars_Dealership_DBProject.Buyer
{
    partial class Buyer_Login
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
            this.Search_button = new System.Windows.Forms.Button();
            this.SignIn_button = new System.Windows.Forms.Button();
            this.SignUp_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Search_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Search_button.Location = new System.Drawing.Point(105, 140);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(262, 75);
            this.Search_button.TabIndex = 9;
            this.Search_button.Text = "View Offered Cars";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // SignIn_button
            // 
            this.SignIn_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignIn_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_button.ForeColor = System.Drawing.SystemColors.Info;
            this.SignIn_button.Location = new System.Drawing.Point(26, 325);
            this.SignIn_button.Name = "SignIn_button";
            this.SignIn_button.Size = new System.Drawing.Size(169, 62);
            this.SignIn_button.TabIndex = 10;
            this.SignIn_button.Text = "Sign In";
            this.SignIn_button.UseVisualStyleBackColor = false;
            this.SignIn_button.Click += new System.EventHandler(this.SignIn_button_Click);
            // 
            // SignUp_button
            // 
            this.SignUp_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignUp_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_button.ForeColor = System.Drawing.SystemColors.Info;
            this.SignUp_button.Location = new System.Drawing.Point(273, 325);
            this.SignUp_button.Name = "SignUp_button";
            this.SignUp_button.Size = new System.Drawing.Size(169, 62);
            this.SignUp_button.TabIndex = 11;
            this.SignUp_button.Text = "Sign Up";
            this.SignUp_button.UseVisualStyleBackColor = false;
            this.SignUp_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::Cars_Dealership_DBProject.Properties.Resources.buyer;
            this.pictureBox1.Location = new System.Drawing.Point(114, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 826);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back_button.Location = new System.Drawing.Point(651, 569);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(73, 31);
            this.Back_button.TabIndex = 17;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Buyer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(736, 612);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.SignUp_button);
            this.Controls.Add(this.SignIn_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Buyer_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buyer_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button SignIn_button;
        private System.Windows.Forms.Button SignUp_button;
        private System.Windows.Forms.Button Back_button;
    }
}