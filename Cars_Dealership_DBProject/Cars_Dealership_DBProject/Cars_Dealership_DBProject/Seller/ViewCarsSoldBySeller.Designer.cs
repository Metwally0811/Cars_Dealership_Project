
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
            this.Back_but_viewcarssold = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarsSoldSeller_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewCarsSoldSeller_dataGridView
            // 
            this.ViewCarsSoldSeller_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCarsSoldSeller_dataGridView.Location = new System.Drawing.Point(31, 61);
            this.ViewCarsSoldSeller_dataGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ViewCarsSoldSeller_dataGridView.Name = "ViewCarsSoldSeller_dataGridView";
            this.ViewCarsSoldSeller_dataGridView.RowHeadersWidth = 51;
            this.ViewCarsSoldSeller_dataGridView.RowTemplate.Height = 26;
            this.ViewCarsSoldSeller_dataGridView.Size = new System.Drawing.Size(1759, 370);
            this.ViewCarsSoldSeller_dataGridView.TabIndex = 0;
            this.ViewCarsSoldSeller_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewCarsSoldSeller_dataGridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Back_but_viewcarssold);
            this.groupBox1.Controls.Add(this.ViewCarsSoldSeller_dataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(1790, 598);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Old Sold Cars";
            // 
            // Back_but_viewcarssold
            // 
            this.Back_but_viewcarssold.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Back_but_viewcarssold.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_but_viewcarssold.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Back_but_viewcarssold.Location = new System.Drawing.Point(1521, 469);
            this.Back_but_viewcarssold.Margin = new System.Windows.Forms.Padding(5);
            this.Back_but_viewcarssold.Name = "Back_but_viewcarssold";
            this.Back_but_viewcarssold.Size = new System.Drawing.Size(237, 84);
            this.Back_but_viewcarssold.TabIndex = 10;
            this.Back_but_viewcarssold.Text = "Back";
            this.Back_but_viewcarssold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Back_but_viewcarssold.UseVisualStyleBackColor = false;
            this.Back_but_viewcarssold.Click += new System.EventHandler(this.Back_but_viewcarssold_Click);
            // 
            // ViewCarsSoldBySeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1959, 656);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
        private System.Windows.Forms.Button Back_but_viewcarssold;
    }
}