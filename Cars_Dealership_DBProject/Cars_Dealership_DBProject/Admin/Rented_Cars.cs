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
    public partial class Rented_Cars : Form
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
        public Rented_Cars()
        {
            InitializeComponent();
            controllerObj = new Controller();


            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //baload el warehouse_combobox
            DataTable dt1 = new DataTable();
            dt1 = controllerObj.SelectWarehouses(); //OD proc test
            WhareHouse_comboBox.DataSource = dt1;
            WhareHouse_comboBox.DisplayMember = "District";
            WhareHouse_comboBox.ValueMember = "W_Id";

            DataTable dt = new DataTable();
            dt = controllerObj.Get_Rented_Cars();

            //baload el datagrid view
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            //baload el car_rented_combobox
            Car_Rented_Vin_combobox.DataSource = dt;
            Car_Rented_Vin_combobox.DisplayMember = "Vin";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Vin_Rentedcars_Admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Retrive_Rented_Car_Button_Click(object sender, EventArgs e)
        {
            //1.yset el rent_flag be 0 we el w_flag be 1 we el w_id be el warehouse el selected
            //2.yshelo mn el cars_out_rent
            int done_query = controllerObj.Retrive_Car_From_Cars_Out_rent(Car_Rented_Vin_combobox.Text, Convert.ToInt32(WhareHouse_comboBox.SelectedValue.ToString()));

            if (done_query==0)
            {
                MessageBox.Show("No car was Retrieved");
            }
            else
            {
                MessageBox.Show("cars was Retrieved");
            }


        }

        private void WhareHouse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities AF = new AdminFunctionalities();
            AF.Show();

            this.Close();
        }
    }
}




