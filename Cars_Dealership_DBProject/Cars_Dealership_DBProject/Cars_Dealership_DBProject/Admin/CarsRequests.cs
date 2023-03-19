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

namespace Cars_Dealership_DBProject.Admin
{
    public partial class CarsRequests : Form
    {
        Controller controllerObj;
        public CarsRequests()
        {

            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt = controllerObj.SelectSellerNames();
            SellerLName_comboBox.DataSource = dt;
            SellerFName_comboBox.DataSource = dt;

            SellerLName_comboBox.DisplayMember = "L_Name";
            SellerFName_comboBox.DisplayMember = "F_Name";

            



            MaintainanceCenter_comboBox.Enabled = false;
            DataTable dt1 = controllerObj.SelectMaintainanceCenters();
            MaintainanceCenter_comboBox.DataSource = dt1;
            MaintainanceCenter_comboBox.DisplayMember = "District";
            



        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities AFunc2 = new AdminFunctionalities();
            AFunc2.Show();

            this.Close();
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            if(Accepted_radioButton.Checked == true)
            {
                DataTable dt1 = new DataTable();
                dt1 = controllerObj.SelectMaintainanaceId(MaintainanceCenter_comboBox.Text);
                string MID = dt1.Rows[0][0].ToString();
                int result = controllerObj.MoveToMaintainance(CarVIN_comboBox.Text, Convert.ToInt32(MID));

                if(result!= 0)
                {
                    MessageBox.Show("Car Added to Maintainance Successfully !");
                }
                else
                {
                    MessageBox.Show("No Car Added to Maintainance");

                }
       
            }
            else
            {
                MessageBox.Show("No Car is Accepted");
                this.Close();

                AdminFunctionalities Adlog = new AdminFunctionalities();
                Adlog.Show();

            }

        }

        private void Excute_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectSellerOfferedCars(SellerFName_comboBox.Text, SellerLName_comboBox.Text);


            if( dt != null)
            {
                ViewSellerCars_dataGridView.DataSource = dt;
                ViewSellerCars_dataGridView.Refresh();

                CarVIN_comboBox.DataSource = dt;
                CarVIN_comboBox.DisplayMember = "Vin";
               

            }
            else
            {
                MessageBox.Show("This Seller has No Cars");
            }
         
        }

        private void Accepted_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            MaintainanceCenter_comboBox.Enabled = true;
          
        }

        private void Rejected_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            MaintainanceCenter_comboBox.Enabled = false;

        }

        private void ViewSellerCars_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
