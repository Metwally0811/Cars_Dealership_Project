using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Admin
{
    public partial class AddToWhareHouse : Form
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
        public AddToWhareHouse()
        {
            InitializeComponent();
            controllerObj = new Controller();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            DataTable dt = new DataTable();
            dt = controllerObj.SelectWarehouses(); //OD proc test
            WhareHouse_comboBox.DataSource = dt;
            WhareHouse_comboBox.DisplayMember = "District";
            WhareHouse_comboBox.ValueMember = "W_Id";


        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities AFunc3 = new AdminFunctionalities();
            AFunc3.Show();

            this.Close();
        }

        private void Move_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controllerObj.SelectWarehousesId(WhareHouse_comboBox.Text);
            //string WID = dt.Rows[0][0].ToString();
            //int r = controllerObj.MoveToWharehouse(VIN_comboBox.Text, Convert.ToInt32(WID));
            int r = controllerObj.MoveToWharehouse(VIN_comboBox.Text, Convert.ToInt32(WhareHouse_comboBox.SelectedValue.ToString()),(int)Newpricenum.Value, (int)rentpriceperday_num.Value);
            if (r ==1 )
            {
                MessageBox.Show("Car Added to WareHouse Successfully !");
                dt = controllerObj.SelectAllCarsInMaintince();

                ViewMaintainanceCars_dataGridView.DataSource = dt;
                ViewMaintainanceCars_dataGridView.Refresh();

                VIN_comboBox.DataSource = dt;
                VIN_comboBox.DisplayMember = "Vin";

            }
            else
            {
                MessageBox.Show("No Car Added to WareHouse");

            }
               
        }

        private void AddToWhareHouse_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controllerObj.SelectAllCarsInMaintince();

            ViewMaintainanceCars_dataGridView.DataSource = dt;
            ViewMaintainanceCars_dataGridView.Refresh();

            VIN_comboBox.DataSource = dt;
            VIN_comboBox.DisplayMember = "Vin";
        }

        private void WhareHouse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewMaintainanceCars_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Newpricenum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rentpriceperday_num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void VIN_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bset el num be min el price bta3 el 3arbya ely mkhtarha fe el combobox bta3 el vin
            /*DataTable datat2 = new DataTable();
            datat2 = controllerObj.Price_of_car_from_vin(VIN_comboBox.Text);
            if (datat2 != null)
            {
                int price = Convert.ToInt32(datat2.Rows[0][0].ToString());
                Newpricenum.Minimum = price;
            }*/
        }
    }
}


///todo   add price and price per day
/// 3izin u4of el price bta3 el car el adem