
namespace Cars_Dealership_DBProject.Admin
{
    partial class CarsRequests
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
            this.SellerLName_comboBox = new System.Windows.Forms.ComboBox();
            this.ViewSellerCars_dataGridView = new System.Windows.Forms.DataGridView();
            this.CarVIN_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Excute_button = new System.Windows.Forms.Button();
            this.SellerFName_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Done_button = new System.Windows.Forms.Button();
            this.MaintainanceCenter_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rejected_radioButton = new System.Windows.Forms.RadioButton();
            this.Accepted_radioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSellerCars_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seller Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car VIN";
            // 
            // SellerLName_comboBox
            // 
            this.SellerLName_comboBox.FormattingEnabled = true;
            this.SellerLName_comboBox.Location = new System.Drawing.Point(627, 64);
            this.SellerLName_comboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SellerLName_comboBox.Name = "SellerLName_comboBox";
            this.SellerLName_comboBox.Size = new System.Drawing.Size(280, 41);
            this.SellerLName_comboBox.TabIndex = 4;
            // 
            // ViewSellerCars_dataGridView
            // 
            this.ViewSellerCars_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSellerCars_dataGridView.Location = new System.Drawing.Point(17, 147);
            this.ViewSellerCars_dataGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewSellerCars_dataGridView.Name = "ViewSellerCars_dataGridView";
            this.ViewSellerCars_dataGridView.RowHeadersWidth = 51;
            this.ViewSellerCars_dataGridView.RowTemplate.Height = 26;
            this.ViewSellerCars_dataGridView.Size = new System.Drawing.Size(1774, 331);
            this.ViewSellerCars_dataGridView.TabIndex = 5;
            this.ViewSellerCars_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewSellerCars_dataGridView_CellContentClick);
            // 
            // CarVIN_comboBox
            // 
            this.CarVIN_comboBox.FormattingEnabled = true;
            this.CarVIN_comboBox.Location = new System.Drawing.Point(201, 77);
            this.CarVIN_comboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CarVIN_comboBox.Name = "CarVIN_comboBox";
            this.CarVIN_comboBox.Size = new System.Drawing.Size(234, 41);
            this.CarVIN_comboBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Excute_button);
            this.groupBox1.Controls.Add(this.SellerFName_comboBox);
            this.groupBox1.Controls.Add(this.ViewSellerCars_dataGridView);
            this.groupBox1.Controls.Add(this.SellerLName_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(1802, 512);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for Offered Cars by Seller";
            // 
            // Excute_button
            // 
            this.Excute_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Excute_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excute_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Excute_button.Location = new System.Drawing.Point(1263, 48);
            this.Excute_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Excute_button.Name = "Excute_button";
            this.Excute_button.Size = new System.Drawing.Size(262, 64);
            this.Excute_button.TabIndex = 13;
            this.Excute_button.Text = "Excute";
            this.Excute_button.UseVisualStyleBackColor = false;
            this.Excute_button.Click += new System.EventHandler(this.Excute_button_Click);
            // 
            // SellerFName_comboBox
            // 
            this.SellerFName_comboBox.FormattingEnabled = true;
            this.SellerFName_comboBox.Location = new System.Drawing.Point(283, 64);
            this.SellerFName_comboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SellerFName_comboBox.Name = "SellerFName_comboBox";
            this.SellerFName_comboBox.Size = new System.Drawing.Size(280, 41);
            this.SellerFName_comboBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Back_button);
            this.groupBox2.Controls.Add(this.Done_button);
            this.groupBox2.Controls.Add(this.MaintainanceCenter_comboBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Rejected_radioButton);
            this.groupBox2.Controls.Add(this.Accepted_radioButton);
            this.groupBox2.Controls.Add(this.CarVIN_comboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 627);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(1555, 434);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Car";
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Back_button.Location = new System.Drawing.Point(864, 341);
            this.Back_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(309, 64);
            this.Back_button.TabIndex = 12;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Done_button
            // 
            this.Done_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Done_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Done_button.Location = new System.Drawing.Point(1210, 341);
            this.Done_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(307, 64);
            this.Done_button.TabIndex = 11;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = false;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // MaintainanceCenter_comboBox
            // 
            this.MaintainanceCenter_comboBox.FormattingEnabled = true;
            this.MaintainanceCenter_comboBox.Location = new System.Drawing.Point(771, 183);
            this.MaintainanceCenter_comboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaintainanceCenter_comboBox.Name = "MaintainanceCenter_comboBox";
            this.MaintainanceCenter_comboBox.Size = new System.Drawing.Size(234, 41);
            this.MaintainanceCenter_comboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(379, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maintainance Center";
            // 
            // Rejected_radioButton
            // 
            this.Rejected_radioButton.AutoSize = true;
            this.Rejected_radioButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rejected_radioButton.Location = new System.Drawing.Point(31, 272);
            this.Rejected_radioButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Rejected_radioButton.Name = "Rejected_radioButton";
            this.Rejected_radioButton.Size = new System.Drawing.Size(172, 38);
            this.Rejected_radioButton.TabIndex = 8;
            this.Rejected_radioButton.TabStop = true;
            this.Rejected_radioButton.Text = "Rejected";
            this.Rejected_radioButton.UseVisualStyleBackColor = true;
            this.Rejected_radioButton.CheckedChanged += new System.EventHandler(this.Rejected_radioButton_CheckedChanged);
            // 
            // Accepted_radioButton
            // 
            this.Accepted_radioButton.AutoSize = true;
            this.Accepted_radioButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accepted_radioButton.Location = new System.Drawing.Point(31, 184);
            this.Accepted_radioButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Accepted_radioButton.Name = "Accepted_radioButton";
            this.Accepted_radioButton.Size = new System.Drawing.Size(177, 38);
            this.Accepted_radioButton.TabIndex = 7;
            this.Accepted_radioButton.TabStop = true;
            this.Accepted_radioButton.Text = "Accepted";
            this.Accepted_radioButton.UseVisualStyleBackColor = true;
            this.Accepted_radioButton.CheckedChanged += new System.EventHandler(this.Accepted_radioButton_CheckedChanged);
            // 
            // CarsRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1857, 1133);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CarsRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsRequests";
            ((System.ComponentModel.ISupportInitialize)(this.ViewSellerCars_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SellerLName_comboBox;
        private System.Windows.Forms.DataGridView ViewSellerCars_dataGridView;
        private System.Windows.Forms.ComboBox CarVIN_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox MaintainanceCenter_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Rejected_radioButton;
        private System.Windows.Forms.RadioButton Accepted_radioButton;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.ComboBox SellerFName_comboBox;
        private System.Windows.Forms.Button Excute_button;
    }
}