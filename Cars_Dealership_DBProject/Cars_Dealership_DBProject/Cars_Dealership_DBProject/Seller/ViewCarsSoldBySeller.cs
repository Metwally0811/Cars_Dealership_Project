using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Seller
{
    public partial class ViewCarsSoldBySeller : Form
    {
        Controller controllerObj;
        string seller_username;

        public ViewCarsSoldBySeller(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            seller_username = username;

            //MJ -> bakhod el username we barg3 mno el ssn   
            DataTable dt = new DataTable();
            dt = controllerObj.Sellerssn_From_Username(seller_username);
            int ssn = Convert.ToInt32(dt.Rows[0][0].ToString()); // ssn feha int el ssn bta3 el seller ely 3amel login

            DataTable dt1 = new DataTable();

            dt1 = controllerObj.Sold_car_with_Sellerssn(ssn);

            ViewCarsSoldSeller_dataGridView.DataSource = dt1;
            ViewCarsSoldSeller_dataGridView.Refresh();


        }

        private void ViewCarsSoldSeller_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Back_but_viewcarssold_Click(object sender, EventArgs e)
        {
            SellerFunctionalities Sf1 = new SellerFunctionalities(seller_username); // OD
            Sf1.Show();

            this.Close();
        }
    }
}
