
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
            this.ViewBorR_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.View_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewBorR_comboBox
            // 
            this.ViewBorR_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewBorR_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewBorR_comboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBorR_comboBox.FormattingEnabled = true;
            this.ViewBorR_comboBox.Items.AddRange(new object[] {
            "Current Rented Cars",
            "Bought Cars"});
            this.ViewBorR_comboBox.Location = new System.Drawing.Point(535, 79);
            this.ViewBorR_comboBox.Name = "ViewBorR_comboBox";
            this.ViewBorR_comboBox.Size = new System.Drawing.Size(223, 32);
            this.ViewBorR_comboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(417, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(463, 35);
            this.label5.TabIndex = 29;
            this.label5.Text = "Bought Cars or Current rented cars";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Back_button.Location = new System.Drawing.Point(1167, 477);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(138, 42);
            this.Back_button.TabIndex = 30;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 319);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // View_Button
            // 
            this.View_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.View_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.View_Button.Location = new System.Drawing.Point(988, 66);
            this.View_Button.Name = "View_Button";
            this.View_Button.Size = new System.Drawing.Size(138, 41);
            this.View_Button.TabIndex = 32;
            this.View_Button.Text = "View";
            this.View_Button.UseVisualStyleBackColor = false;
            this.View_Button.Click += new System.EventHandler(this.View_Button_Click);
            // 
            // ViewPastTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 542);
            this.Controls.Add(this.View_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ViewBorR_comboBox);
            this.Name = "ViewPastTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPastTransactions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ViewBorR_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View_Button;
    }
}