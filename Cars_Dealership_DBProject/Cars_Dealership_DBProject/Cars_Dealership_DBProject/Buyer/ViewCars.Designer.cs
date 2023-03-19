
namespace Cars_Dealership_DBProject.Buyer
{
    partial class ViewCars
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SignIn_button = new System.Windows.Forms.Button();
            this.SignUp_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 449);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Offered Cars";
            // 
            // SignIn_button
            // 
            this.SignIn_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SignIn_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignIn_button.Location = new System.Drawing.Point(481, 514);
            this.SignIn_button.Name = "SignIn_button";
            this.SignIn_button.Size = new System.Drawing.Size(138, 54);
            this.SignIn_button.TabIndex = 11;
            this.SignIn_button.Text = "Sign In";
            this.SignIn_button.UseVisualStyleBackColor = false;
            this.SignIn_button.Click += new System.EventHandler(this.SignIn_button_Click);
            // 
            // SignUp_button
            // 
            this.SignUp_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SignUp_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SignUp_button.Location = new System.Drawing.Point(842, 514);
            this.SignUp_button.Name = "SignUp_button";
            this.SignUp_button.Size = new System.Drawing.Size(138, 54);
            this.SignUp_button.TabIndex = 12;
            this.SignUp_button.Text = "Sign Up";
            this.SignUp_button.UseVisualStyleBackColor = false;
            this.SignUp_button.Click += new System.EventHandler(this.SignUp_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Back_button.Location = new System.Drawing.Point(114, 514);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(138, 54);
            this.Back_button.TabIndex = 13;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // ViewCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 590);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.SignUp_button);
            this.Controls.Add(this.SignIn_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SignIn_button;
        private System.Windows.Forms.Button SignUp_button;
        private System.Windows.Forms.Button Back_button;
    }
}