
namespace Cars_Dealership_DBProject.Admin
{
    partial class AddAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.LName_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.FName_textBox = new System.Windows.Forms.TextBox();
            this.AddNewAdmin_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(30, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(30, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(30, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Password_textBox);
            this.groupBox1.Controls.Add(this.LName_textBox);
            this.groupBox1.Controls.Add(this.Username_textBox);
            this.groupBox1.Controls.Add(this.FName_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 349);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Admin Details";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(204, 269);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(187, 24);
            this.Password_textBox.TabIndex = 9;
            // 
            // LName_textBox
            // 
            this.LName_textBox.Location = new System.Drawing.Point(204, 117);
            this.LName_textBox.Name = "LName_textBox";
            this.LName_textBox.Size = new System.Drawing.Size(187, 24);
            this.LName_textBox.TabIndex = 8;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(204, 194);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(187, 24);
            this.Username_textBox.TabIndex = 7;
            this.Username_textBox.TextChanged += new System.EventHandler(this.Username_textBox_TextChanged);
            // 
            // FName_textBox
            // 
            this.FName_textBox.Location = new System.Drawing.Point(204, 48);
            this.FName_textBox.Name = "FName_textBox";
            this.FName_textBox.Size = new System.Drawing.Size(187, 24);
            this.FName_textBox.TabIndex = 6;
            this.FName_textBox.TextChanged += new System.EventHandler(this.FName_textBox_TextChanged);
            // 
            // AddNewAdmin_button
            // 
            this.AddNewAdmin_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddNewAdmin_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewAdmin_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddNewAdmin_button.Location = new System.Drawing.Point(340, 419);
            this.AddNewAdmin_button.Name = "AddNewAdmin_button";
            this.AddNewAdmin_button.Size = new System.Drawing.Size(138, 38);
            this.AddNewAdmin_button.TabIndex = 8;
            this.AddNewAdmin_button.Text = "Add";
            this.AddNewAdmin_button.UseVisualStyleBackColor = false;
            this.AddNewAdmin_button.Click += new System.EventHandler(this.AddNewAdmin_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Back_button.Location = new System.Drawing.Point(28, 419);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(138, 38);
            this.Back_button.TabIndex = 9;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 490);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.AddNewAdmin_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAdmin";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox LName_textBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.TextBox FName_textBox;
        private System.Windows.Forms.Button AddNewAdmin_button;
        private System.Windows.Forms.Button Back_button;
    }
}