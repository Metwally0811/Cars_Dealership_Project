
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
            this.WhareHouse_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VIN_comboBox = new System.Windows.Forms.ComboBox();
            this.Move_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMaintainanceCars_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewMaintainanceCars_dataGridView
            // 
            this.ViewMaintainanceCars_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewMaintainanceCars_dataGridView.Location = new System.Drawing.Point(38, 61);
            this.ViewMaintainanceCars_dataGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewMaintainanceCars_dataGridView.Name = "ViewMaintainanceCars_dataGridView";
            this.ViewMaintainanceCars_dataGridView.RowHeadersWidth = 51;
            this.ViewMaintainanceCars_dataGridView.RowTemplate.Height = 26;
            this.ViewMaintainanceCars_dataGridView.Size = new System.Drawing.Size(1579, 341);
            this.ViewMaintainanceCars_dataGridView.TabIndex = 0;
            this.ViewMaintainanceCars_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewMaintainanceCars_dataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewMaintainanceCars_dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(1646, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Cars in Maintainance Center";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WhareHouse_comboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.VIN_comboBox);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 525);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(1329, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Car";
            // 
            // WhareHouse_comboBox
            // 
            this.WhareHouse_comboBox.FormattingEnabled = true;
            this.WhareHouse_comboBox.Location = new System.Drawing.Point(977, 98);
            this.WhareHouse_comboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.WhareHouse_comboBox.Name = "WhareHouse_comboBox";
            this.WhareHouse_comboBox.Size = new System.Drawing.Size(283, 41);
            this.WhareHouse_comboBox.TabIndex = 6;
            this.WhareHouse_comboBox.SelectedIndexChanged += new System.EventHandler(this.WhareHouse_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(689, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "WhareHouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Car VIN";
            // 
            // VIN_comboBox
            // 
            this.VIN_comboBox.FormattingEnabled = true;
            this.VIN_comboBox.Location = new System.Drawing.Point(230, 98);
            this.VIN_comboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.VIN_comboBox.Name = "VIN_comboBox";
            this.VIN_comboBox.Size = new System.Drawing.Size(331, 41);
            this.VIN_comboBox.TabIndex = 0;
            // 
            // Move_button
            // 
            this.Move_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Move_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Move_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Move_button.Location = new System.Drawing.Point(1337, 834);
            this.Move_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Move_button.Name = "Move_button";
            this.Move_button.Size = new System.Drawing.Size(307, 64);
            this.Move_button.TabIndex = 12;
            this.Move_button.Text = "Move";
            this.Move_button.UseVisualStyleBackColor = false;
            this.Move_button.Click += new System.EventHandler(this.Move_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Back_button.Location = new System.Drawing.Point(989, 834);
            this.Back_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(307, 64);
            this.Back_button.TabIndex = 13;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // AddToWhareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 928);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Move_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddToWhareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToWhareHouse";
            this.Load += new System.EventHandler(this.AddToWhareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewMaintainanceCars_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}