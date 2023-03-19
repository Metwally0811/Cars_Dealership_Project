
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Search_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Search_button.Location = new System.Drawing.Point(154, 204);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(146, 74);
            this.Search_button.TabIndex = 9;
            this.Search_button.Text = "View Offered Cars";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // SignIn_button
            // 
            this.SignIn_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SignIn_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignIn_button.Location = new System.Drawing.Point(12, 308);
            this.SignIn_button.Name = "SignIn_button";
            this.SignIn_button.Size = new System.Drawing.Size(138, 54);
            this.SignIn_button.TabIndex = 10;
            this.SignIn_button.Text = "Sign In";
            this.SignIn_button.UseVisualStyleBackColor = false;
            this.SignIn_button.Click += new System.EventHandler(this.SignIn_button_Click);
            // 
            // SignUp_button
            // 
            this.SignUp_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SignUp_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignUp_button.Location = new System.Drawing.Point(301, 308);
            this.SignUp_button.Name = "SignUp_button";
            this.SignUp_button.Size = new System.Drawing.Size(138, 54);
            this.SignUp_button.TabIndex = 11;
            this.SignUp_button.Text = "Sign Up";
            this.SignUp_button.UseVisualStyleBackColor = false;
            this.SignUp_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::Cars_Dealership_DBProject.Properties.Resources.buyer;
            this.pictureBox1.Location = new System.Drawing.Point(167, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Buyer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(466, 406);
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
    }
}