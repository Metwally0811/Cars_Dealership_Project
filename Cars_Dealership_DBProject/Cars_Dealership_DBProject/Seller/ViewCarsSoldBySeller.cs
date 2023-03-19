using DBapplication;
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

namespace Cars_Dealership_DBProject.Seller
{
    public partial class ViewCarsSoldBySeller : Form
    {
        Controller controllerObj;
        string seller_username;

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

        public ViewCarsSoldBySeller(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            seller_username = username;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //MJ -> bakhod el username we barg3 mno el ssn   
            DataTable dt = new DataTable();
            dt = controllerObj.Sellerssn_From_Username(seller_username);
            int ssn = Convert.ToInt32(dt.Rows[0][0].ToString()); // ssn feha int el ssn bta3 el seller ely 3amel login

            DataTable dt1 = new DataTable();

            dt1 = controllerObj.Sold_car_with_Sellerssn(ssn);

            ViewCarsSoldSeller_dataGridView.DataSource = dt1;
            ViewCarsSoldSeller_dataGridView.Columns[0].Visible = false;
            ViewCarsSoldSeller_dataGridView.Refresh();

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            SellerFunctionalities Sf1 = new SellerFunctionalities(seller_username); 
            Sf1.Show();

            this.Close();

        }

        private void ViewCarsSoldSeller_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
