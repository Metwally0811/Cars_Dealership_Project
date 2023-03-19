
namespace Cars_Dealership_DBProject.Buyer
{
    partial class BuyOrRent
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Company_comboBox = new System.Windows.Forms.ComboBox();
            this.Year_comboBox = new System.Windows.Forms.ComboBox();
            this.Model_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PriceRange_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Buy_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Day_num = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Month_num = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.year_num = new System.Windows.Forms.NumericUpDown();
            this.noofdays_num = new System.Windows.Forms.NumericUpDown();
            this.Rent_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.VIN_comboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Day_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noofdays_num)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(577, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(351, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(104, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Company";
            // 
            // Company_comboBox
            // 
            this.Company_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Company_comboBox.FormattingEnabled = true;
            this.Company_comboBox.Location = new System.Drawing.Point(63, 82);
            this.Company_comboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Company_comboBox.Name = "Company_comboBox";
            this.Company_comboBox.Size = new System.Drawing.Size(185, 34);
            this.Company_comboBox.TabIndex = 33;
            this.Company_comboBox.SelectionChangeCommitted += new System.EventHandler(this.button1_Click);
            // 
            // Year_comboBox
            // 
            this.Year_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year_comboBox.FormattingEnabled = true;
            this.Year_comboBox.Location = new System.Drawing.Point(532, 82);
            this.Year_comboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Year_comboBox.Name = "Year_comboBox";
            this.Year_comboBox.Size = new System.Drawing.Size(156, 34);
            this.Year_comboBox.TabIndex = 34;
            this.Year_comboBox.SelectionChangeCommitted += new System.EventHandler(this.button3_Click);
            // 
            // Model_comboBox
            // 
            this.Model_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Model_comboBox.FormattingEnabled = true;
            this.Model_comboBox.Location = new System.Drawing.Point(310, 82);
            this.Model_comboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Model_comboBox.Name = "Model_comboBox";
            this.Model_comboBox.Size = new System.Drawing.Size(150, 34);
            this.Model_comboBox.TabIndex = 35;
            this.Model_comboBox.SelectionChangeCommitted += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 168);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.PriceRange_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Model_comboBox);
            this.groupBox1.Controls.Add(this.Year_comboBox);
            this.groupBox1.Controls.Add(this.Company_comboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(30, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(1180, 361);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Info";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(892, 133);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(195, 30);
            this.radioButton2.TabIndex = 43;
            this.radioButton2.Text = "Filter by Price Range";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButton1.Location = new System.Drawing.Point(63, 133);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(275, 30);
            this.radioButton1.TabIndex = 42;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Filter by Company, Model, Year";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PriceRange_comboBox
            // 
            this.PriceRange_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceRange_comboBox.FormattingEnabled = true;
            this.PriceRange_comboBox.Items.AddRange(new object[] {
            "Less than 100,000",
            "100,000 to 250,000",
            "250,000 to 500,000",
            "500,000 to 1000,000",
            "Above 1000,000"});
            this.PriceRange_comboBox.Location = new System.Drawing.Point(882, 82);
            this.PriceRange_comboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PriceRange_comboBox.Name = "PriceRange_comboBox";
            this.PriceRange_comboBox.Size = new System.Drawing.Size(203, 34);
            this.PriceRange_comboBox.TabIndex = 41;
            this.PriceRange_comboBox.SelectionChangeCommitted += new System.EventHandler(this.button4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(904, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Price Range";
            // 
            // Buy_button
            // 
            this.Buy_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Buy_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buy_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Buy_button.Location = new System.Drawing.Point(503, 400);
            this.Buy_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Buy_button.Name = "Buy_button";
            this.Buy_button.Size = new System.Drawing.Size(138, 43);
            this.Buy_button.TabIndex = 41;
            this.Buy_button.Text = "Buy";
            this.Buy_button.UseVisualStyleBackColor = false;
            this.Buy_button.Click += new System.EventHandler(this.Buy_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Day_num);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Month_num);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.year_num);
            this.groupBox2.Controls.Add(this.noofdays_num);
            this.groupBox2.Controls.Add(this.Rent_button);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(47, 516);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(624, 252);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rent";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(494, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 24);
            this.label10.TabIndex = 48;
            this.label10.Text = "Day";
            // 
            // Day_num
            // 
            this.Day_num.Location = new System.Drawing.Point(547, 69);
            this.Day_num.Margin = new System.Windows.Forms.Padding(2);
            this.Day_num.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Day_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Day_num.Name = "Day_num";
            this.Day_num.Size = new System.Drawing.Size(70, 34);
            this.Day_num.TabIndex = 46;
            this.Day_num.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.Day_num.ValueChanged += new System.EventHandler(this.Day_num_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(337, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Month";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Month_num
            // 
            this.Month_num.Location = new System.Drawing.Point(415, 70);
            this.Month_num.Margin = new System.Windows.Forms.Padding(2);
            this.Month_num.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Month_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Month_num.Name = "Month_num";
            this.Month_num.Size = new System.Drawing.Size(66, 34);
            this.Month_num.TabIndex = 47;
            this.Month_num.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Month_num.ValueChanged += new System.EventHandler(this.Month_num_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(186, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Year";
            // 
            // year_num
            // 
            this.year_num.Location = new System.Drawing.Point(246, 70);
            this.year_num.Margin = new System.Windows.Forms.Padding(2);
            this.year_num.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.year_num.Minimum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.year_num.Name = "year_num";
            this.year_num.Size = new System.Drawing.Size(73, 34);
            this.year_num.TabIndex = 48;
            this.year_num.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.year_num.ValueChanged += new System.EventHandler(this.year_num_ValueChanged);
            // 
            // noofdays_num
            // 
            this.noofdays_num.Location = new System.Drawing.Point(246, 143);
            this.noofdays_num.Margin = new System.Windows.Forms.Padding(2);
            this.noofdays_num.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.noofdays_num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noofdays_num.Name = "noofdays_num";
            this.noofdays_num.Size = new System.Drawing.Size(70, 34);
            this.noofdays_num.TabIndex = 43;
            this.noofdays_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Rent_button
            // 
            this.Rent_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Rent_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Rent_button.Location = new System.Drawing.Point(478, 203);
            this.Rent_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Rent_button.Name = "Rent_button";
            this.Rent_button.Size = new System.Drawing.Size(138, 43);
            this.Rent_button.TabIndex = 42;
            this.Rent_button.Text = "Rent";
            this.Rent_button.UseVisualStyleBackColor = false;
            this.Rent_button.Click += new System.EventHandler(this.Rent_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(19, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(17, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Number of Days";
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Back_button.Location = new System.Drawing.Point(1052, 719);
            this.Back_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(138, 43);
            this.Back_button.TabIndex = 43;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(43, 411);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Car VIN";
            // 
            // VIN_comboBox
            // 
            this.VIN_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VIN_comboBox.FormattingEnabled = true;
            this.VIN_comboBox.Location = new System.Drawing.Point(162, 409);
            this.VIN_comboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.VIN_comboBox.Name = "VIN_comboBox";
            this.VIN_comboBox.Size = new System.Drawing.Size(255, 24);
            this.VIN_comboBox.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(675, 516);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 46;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(817, 516);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 39);
            this.button2.TabIndex = 47;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(959, 516);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 39);
            this.button3.TabIndex = 48;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(817, 586);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 39);
            this.button4.TabIndex = 49;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // BuyOrRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 786);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VIN_comboBox);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Buy_button);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BuyOrRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " v";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Day_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noofdays_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Company_comboBox;
        private System.Windows.Forms.ComboBox Year_comboBox;
        private System.Windows.Forms.ComboBox Model_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Buy_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Rent_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox VIN_comboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Day_num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Month_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown year_num;
        private System.Windows.Forms.NumericUpDown noofdays_num;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox PriceRange_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}