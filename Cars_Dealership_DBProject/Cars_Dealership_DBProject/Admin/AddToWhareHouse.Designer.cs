
namespace Cars_Dealership_DBProject.Admin
{
    partial class AddToWhareHouse
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
            this.ViewMaintainanceCars_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rentpriceperday_num = new System.Windows.Forms.NumericUpDown();
            this.Newpricenum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WhareHouse_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VIN_comboBox = new System.Windows.Forms.ComboBox();
            this.Move_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMaintainanceCars_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentpriceperday_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Newpricenum)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewMaintainanceCars_dataGridView
            // 
            this.ViewMaintainanceCars_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewMaintainanceCars_dataGridView.Location = new System.Drawing.Point(6, 28);
            this.ViewMaintainanceCars_dataGridView.Name = "ViewMaintainanceCars_dataGridView";
            this.ViewMaintainanceCars_dataGridView.RowHeadersWidth = 51;
            this.ViewMaintainanceCars_dataGridView.RowTemplate.Height = 26;
            this.ViewMaintainanceCars_dataGridView.Size = new System.Drawing.Size(1105, 218);
            this.ViewMaintainanceCars_dataGridView.TabIndex = 0;
            this.ViewMaintainanceCars_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewMaintainanceCars_dataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewMaintainanceCars_dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Cars in Maintainance Center";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rentpriceperday_num);
            this.groupBox2.Controls.Add(this.Newpricenum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.WhareHouse_comboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.VIN_comboBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(19, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Car";
            // 
            // rentpriceperday_num
            // 
            this.rentpriceperday_num.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rentpriceperday_num.Location = new System.Drawing.Point(580, 110);
            this.rentpriceperday_num.Margin = new System.Windows.Forms.Padding(2);
            this.rentpriceperday_num.Maximum = new decimal(new int[] {
            7000000,
            0,
            0,
            0});
            this.rentpriceperday_num.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.rentpriceperday_num.Name = "rentpriceperday_num";
            this.rentpriceperday_num.Size = new System.Drawing.Size(164, 28);
            this.rentpriceperday_num.TabIndex = 15;
            this.rentpriceperday_num.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.rentpriceperday_num.ValueChanged += new System.EventHandler(this.rentpriceperday_num_ValueChanged);
            // 
            // Newpricenum
            // 
            this.Newpricenum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Newpricenum.Location = new System.Drawing.Point(163, 110);
            this.Newpricenum.Margin = new System.Windows.Forms.Padding(2);
            this.Newpricenum.Maximum = new decimal(new int[] {
            7000000,
            0,
            0,
            0});
            this.Newpricenum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Newpricenum.Name = "Newpricenum";
            this.Newpricenum.Size = new System.Drawing.Size(164, 28);
            this.Newpricenum.TabIndex = 14;
            this.Newpricenum.Value = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.Newpricenum.ValueChanged += new System.EventHandler(this.Newpricenum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(387, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rent price per day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "New Price";
            // 
            // WhareHouse_comboBox
            // 
            this.WhareHouse_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WhareHouse_comboBox.FormattingEnabled = true;
            this.WhareHouse_comboBox.Location = new System.Drawing.Point(580, 61);
            this.WhareHouse_comboBox.Name = "WhareHouse_comboBox";
            this.WhareHouse_comboBox.Size = new System.Drawing.Size(166, 28);
            this.WhareHouse_comboBox.TabIndex = 6;
            this.WhareHouse_comboBox.SelectedIndexChanged += new System.EventHandler(this.WhareHouse_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(402, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "WhareHouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Car VIN";
            // 
            // VIN_comboBox
            // 
            this.VIN_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VIN_comboBox.FormattingEnabled = true;
            this.VIN_comboBox.Location = new System.Drawing.Point(163, 63);
            this.VIN_comboBox.Name = "VIN_comboBox";
            this.VIN_comboBox.Size = new System.Drawing.Size(166, 28);
            this.VIN_comboBox.TabIndex = 0;
            this.VIN_comboBox.SelectedIndexChanged += new System.EventHandler(this.VIN_comboBox_SelectedIndexChanged);
            // 
            // Move_button
            // 
            this.Move_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Move_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Move_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Move_button.Location = new System.Drawing.Point(891, 388);
            this.Move_button.Name = "Move_button";
            this.Move_button.Size = new System.Drawing.Size(179, 41);
            this.Move_button.TabIndex = 12;
            this.Move_button.Text = "Move";
            this.Move_button.UseVisualStyleBackColor = false;
            this.Move_button.Click += new System.EventHandler(this.Move_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Back_button.Location = new System.Drawing.Point(891, 470);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(179, 41);
            this.Back_button.TabIndex = 13;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // AddToWhareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1199, 565);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Move_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddToWhareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToWhareHouse";
            this.Load += new System.EventHandler(this.AddToWhareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewMaintainanceCars_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentpriceperday_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Newpricenum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewMaintainanceCars_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox VIN_comboBox;
        private System.Windows.Forms.ComboBox WhareHouse_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Move_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.NumericUpDown rentpriceperday_num;
        private System.Windows.Forms.NumericUpDown Newpricenum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}