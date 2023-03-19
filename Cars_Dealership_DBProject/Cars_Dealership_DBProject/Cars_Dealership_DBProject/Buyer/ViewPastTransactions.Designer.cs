
namespace Cars_Dealership_DBProject.Buyer
{
    partial class ViewPastTransactions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ViewPastTrans_dataGridView = new System.Windows.Forms.DataGridView();
            this.ViewBorR_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPastTrans_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewPastTrans_dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Past Bought or Rented Cars";
            // 
            // ViewPastTrans_dataGridView
            // 
            this.ViewPastTrans_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPastTrans_dataGridView.Location = new System.Drawing.Point(28, 55);
            this.ViewPastTrans_dataGridView.Name = "ViewPastTrans_dataGridView";
            this.ViewPastTrans_dataGridView.RowHeadersWidth = 51;
            this.ViewPastTrans_dataGridView.RowTemplate.Height = 26;
            this.ViewPastTrans_dataGridView.Size = new System.Drawing.Size(1062, 266);
            this.ViewPastTrans_dataGridView.TabIndex = 0;
            // 
            // ViewBorR_comboBox
            // 
            this.ViewBorR_comboBox.FormattingEnabled = true;
            this.ViewBorR_comboBox.Location = new System.Drawing.Point(403, 78);
            this.ViewBorR_comboBox.Name = "ViewBorR_comboBox";
            this.ViewBorR_comboBox.Size = new System.Drawing.Size(275, 24);
            this.ViewBorR_comboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(412, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "View Bought or Rented";
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Back_button.Location = new System.Drawing.Point(991, 530);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(138, 38);
            this.Back_button.TabIndex = 30;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // ViewPastTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 580);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ViewBorR_comboBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewPastTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPastTransactions";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPastTrans_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ViewPastTrans_dataGridView;
        private System.Windows.Forms.ComboBox ViewBorR_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back_button;
    }
}