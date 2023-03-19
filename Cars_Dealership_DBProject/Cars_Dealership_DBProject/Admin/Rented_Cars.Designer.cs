namespace Cars_Dealership_DBProject.Admin
{
    partial class Rented_Cars
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Retrive_Rented_Car_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WhareHouse_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Car_Rented_Vin_combobox = new System.Windows.Forms.ComboBox();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(761, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Rented cars";
            // 
            // Retrive_Rented_Car_Button
            // 
            this.Retrive_Rented_Car_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Retrive_Rented_Car_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrive_Rented_Car_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.Retrive_Rented_Car_Button.Location = new System.Drawing.Point(522, 433);
            this.Retrive_Rented_Car_Button.Name = "Retrive_Rented_Car_Button";
            this.Retrive_Rented_Car_Button.Size = new System.Drawing.Size(250, 47);
            this.Retrive_Rented_Car_Button.TabIndex = 49;
            this.Retrive_Rented_Car_Button.Text = "Retrive rented car";
            this.Retrive_Rented_Car_Button.UseVisualStyleBackColor = false;
            this.Retrive_Rented_Car_Button.Click += new System.EventHandler(this.Retrive_Rented_Car_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WhareHouse_comboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Car_Rented_Vin_combobox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 131);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Car";
            // 
            // WhareHouse_comboBox
            // 
            this.WhareHouse_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WhareHouse_comboBox.FormattingEnabled = true;
            this.WhareHouse_comboBox.Location = new System.Drawing.Point(567, 63);
            this.WhareHouse_comboBox.Name = "WhareHouse_comboBox";
            this.WhareHouse_comboBox.Size = new System.Drawing.Size(167, 28);
            this.WhareHouse_comboBox.TabIndex = 6;
            this.WhareHouse_comboBox.SelectedIndexChanged += new System.EventHandler(this.WhareHouse_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(399, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "WhareHouse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Car VIN";
            // 
            // Car_Rented_Vin_combobox
            // 
            this.Car_Rented_Vin_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Car_Rented_Vin_combobox.FormattingEnabled = true;
            this.Car_Rented_Vin_combobox.Location = new System.Drawing.Point(134, 63);
            this.Car_Rented_Vin_combobox.Name = "Car_Rented_Vin_combobox";
            this.Car_Rented_Vin_combobox.Size = new System.Drawing.Size(195, 28);
            this.Car_Rented_Vin_combobox.TabIndex = 0;
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.Back_Button.Location = new System.Drawing.Point(29, 433);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(131, 47);
            this.Back_Button.TabIndex = 51;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Rented_Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 504);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Retrive_Rented_Car_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Rented_Cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rented_Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Retrive_Rented_Car_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox WhareHouse_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Car_Rented_Vin_combobox;
        private System.Windows.Forms.Button Back_Button;
    }
}