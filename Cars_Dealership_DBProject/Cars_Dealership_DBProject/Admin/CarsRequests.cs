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

namespace Cars_Dealership_DBProject.Admin
{
    public partial class CarsRequests : Form
    {
        Controller controllerObj;

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
        public CarsRequests()
        {

            InitializeComponent();
            controllerObj = new Controller();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));





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

                    if (result != 0)
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
                //this.Close();

                //AdminFunctionalities Adlog = new AdminFunctionalities();
                //Adlog.Show();

            }

        }

        private void Excute_button_Click(object sender, EventArgs e)
        {
             
          
         
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

        private void MaintainanceCenter_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarsRequests_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectSellerOfferedCars();

            ViewSellerCars_dataGridView.DataSource = dt;
            ViewSellerCars_dataGridView.Refresh();

            CarVIN_comboBox.DataSource = dt;
            CarVIN_comboBox.DisplayMember = "Vin";


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
