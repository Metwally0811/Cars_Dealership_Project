using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Admin
{
    public partial class Statistics : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public Statistics()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
           


        }

        private void Statistics_Load(object sender, EventArgs e)
        {


            dbChartSalesDataContext db = new dbChartSalesDataContext();
            ChartSales.DataSource = db.viewSales.ToList();

            ChartSales.Series["Sales"].XValueMember = "Company";
            ChartSales.Series["Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            ChartSales.Series["Sales"].YValueMembers = "Sales";
            ChartSales.Series["Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;



        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities a = new AdminFunctionalities();
            a.Show();

            this.Close();
        }
    }
}
