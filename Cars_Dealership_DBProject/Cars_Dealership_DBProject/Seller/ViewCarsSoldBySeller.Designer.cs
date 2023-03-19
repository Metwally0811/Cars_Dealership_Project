
namespace Cars_Dealership_DBProject.Seller
{
    partial class ViewCarsSoldBySeller
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
            this.ViewCarsSoldSeller_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarsSoldSeller_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewCarsSoldSeller_dataGridView
            // 
            this.ViewCarsSoldSeller_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCarsSoldSeller_dataGridView.Location = new System.Drawing.Point(18, 39);
            this.ViewCarsSoldSeller_dataGridView.Name = "ViewCarsSoldSeller_dataGridView";
            this.ViewCarsSoldSeller_dataGridView.RowHeadersWidth = 51;
            this.ViewCarsSoldSeller_dataGridView.RowTemplate.Height = 26;
            this.ViewCarsSoldSeller_dataGridView.Size = new System.Drawing.Size(996, 386);
            this.ViewCarsSoldSeller_dataGridView.TabIndex = 0;
            this.ViewCarsSoldSeller_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewCarsSoldSeller_dataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewCarsSoldSeller_dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 459);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Sold Cars";
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.Info;
            this.Back_button.Location = new System.Drawing.Point(943, 517);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(138, 38);
            this.Back_button.TabIndex = 19;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // ViewCarsSoldBySeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 567);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewCarsSoldBySeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCarsSoldBySeller";
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarsSoldSeller_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewCarsSoldSeller_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Back_button;
    }
}