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
    public partial class AddToWhareHouse : Form
    {
        Controller controllerObj;
        public AddToWhareHouse()
        {
            InitializeComponent();
            controllerObj = new Controller();


            DataTable dt = new DataTable();
            dt = controllerObj.SelectWarehouses();
            WhareHouse_comboBox.DataSource = dt;
            WhareHouse_comboBox.DisplayMember = "District";
          

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
            string WID = dt.Rows[0][0].ToString();
            int r = controllerObj.MoveToWharehouse(VIN_comboBox.Text, Convert.ToInt32(WID));
            if (r ==1 )
            {
                MessageBox.Show("Car Added to WareHouse Successfully !");
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

        private void ViewMaintainanceCars_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WhareHouse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
