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

namespace Cars_Dealership_DBProject.Buyer
{
    public partial class BuyOrRent : Form
    {
        int buyerssn;
        int flag;
        Controller controllerObj;
        DataTable dt2;
        DataTable dt3;
        DataTable dt4;
        DataTable dt5;

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


        public BuyOrRent(int a ,int buy_ssn) // 0 -> Buy / 1-> Rent
        {
            InitializeComponent();
            buyerssn = buy_ssn;
            flag = a;
            controllerObj = new Controller();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            if (a==0)
            {
                //Disable Rent group box 
                groupBox2.Enabled = false;


            }
            else
            {
                groupBox2.Enabled = true;
                Buy_button.Enabled = false;
            }


            //Load comboboxes with data
            DataTable dt1 = new DataTable();
            //dt1 = controllerObj.SelectAllCarsInWareHouse();
            dt1 = controllerObj.SelectCompanyCarsInWareHouse();

            Company_comboBox.DataSource = dt1;
            Company_comboBox.DisplayMember = "Company";

            PriceRange_comboBox.Enabled = false;




        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            BuyerFunctinalities Bfun3 = new BuyerFunctinalities(buyerssn);
            Bfun3.Show();

            this.Close();
        }

        private void Rent_button_Click(object sender, EventArgs e)
        {
            // Hyro7 le form el transaction
            // 1 for rent

            //valdiation en el end date b3d el start date
            if (VIN_comboBox.Text == "")
            {
                MessageBox.Show("No car is selected");

            }
            else
            {


                Payment pay = new Payment(1, VIN_comboBox.Text, (int)year_num.Value , (int)Month_num.Value, (int)Day_num.Value ,(int)noofdays_num.Value , buyerssn);
                pay.Show();

                this.Close();
            }

        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            // 0 for buy
            if (VIN_comboBox.Text == "") //valdiation 3shan lw msh mkhtar vin
            {
                MessageBox.Show("No car is selected");

            }
            else
            {
                Payment pay1 = new Payment(0, VIN_comboBox.Text, (int)year_num.Value, (int)Month_num.Value, (int)Day_num.Value, (int)noofdays_num.Value, buyerssn);
                pay1.Show();


                this.Close();
            }

        }

        private void Done1_button_Click(object sender, EventArgs e)
        {
        }

        private void Done2_button_Click(object sender, EventArgs e)
        {
           

        }

        private void View_button_Click(object sender, EventArgs e)
        {
            

        }

        private void PriceRange_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Month_num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Day_num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void year_num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Year_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //DataTable dt2 = new DataTable();
            dt2 = controllerObj.SelectModelofCompany(Company_comboBox.Text);

            Model_comboBox.DataSource = dt2;
            Model_comboBox.DisplayMember = "Model";

            //DataTable dt3 = new DataTable();
            dt3 = controllerObj.SelectYearofCompanyandModel(Company_comboBox.Text, Model_comboBox.Text);

            Year_comboBox.DataSource = dt3;
            Year_comboBox.DisplayMember = "Year";




            //DataTable dt4 = new DataTable();
            if (Year_comboBox.Text == "" && Model_comboBox.Text == "" && Company_comboBox.Text == "") //ehtyaty
            {

                MessageBox.Show("No Filter is selected");
            }
            else
            { 
                dt4 = controllerObj.SelectcarForBuyer(Company_comboBox.Text, Model_comboBox.Text, Convert.ToInt32(Year_comboBox.Text));
                if (dt4 == null)
                {


                }
                else
                {

                    //baload el data grid view we el combo box bta el vin
                    dataGridView1.DataSource = dt4;
                    dataGridView1.Refresh();

                    Model_comboBox.Enabled = true;
                    Company_comboBox.Enabled = true;

                    VIN_comboBox.DataSource = dt4;
                    VIN_comboBox.DisplayMember = "Vin";
                }

               

            }
       




        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            //DataTable dt3 = new DataTable();
            dt3 = controllerObj.SelectYearofCompanyandModel(Company_comboBox.Text, Model_comboBox.Text);

            Year_comboBox.DataSource = dt3;
            Year_comboBox.DisplayMember = "Year";





            //DataTable dt4 = new DataTable();
            if (Year_comboBox.Text == "" && Model_comboBox.Text == "" && Company_comboBox.Text == "") //ehtyaty
            {

                MessageBox.Show("No Filter is selected");
            }
            else
            {
                dt4 = controllerObj.SelectcarForBuyer(Company_comboBox.Text, Model_comboBox.Text, Convert.ToInt32(Year_comboBox.Text));
                if (dt4 == null)
                {


                }
                else
                {
                    //baload el data grid view we el combo box bta el vin
                    dataGridView1.DataSource = dt4;
                    dataGridView1.Refresh();

                    Model_comboBox.Enabled = true;
                    Company_comboBox.Enabled = true;

                    VIN_comboBox.DataSource = dt4;
                    VIN_comboBox.DisplayMember = "Vin";
                }

            }

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DataTable dt4 = new DataTable();
            if (Year_comboBox.Text == "" && Model_comboBox.Text == "" && Company_comboBox.Text == "") //ehtyaty
            {

                MessageBox.Show("No Filter is selected");
            }
            else
            {
                dt4 = controllerObj.SelectcarForBuyer(Company_comboBox.Text, Model_comboBox.Text, Convert.ToInt32(Year_comboBox.Text));
                if (dt4 == null)
                {


                }
                else
                {
                    //baload el data grid view we el combo box bta el vin
                    dataGridView1.DataSource = dt4;
                    dataGridView1.Refresh();

                    Model_comboBox.Enabled = true;
                    Company_comboBox.Enabled = true;

                    VIN_comboBox.DataSource = dt4;
                    VIN_comboBox.DisplayMember = "Vin";
                }

            }

            


        }

        private void PriceRange_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            

            dt5 = controllerObj.SelectcarForBuyerByPrice(PriceRange_comboBox.SelectedIndex);

            if(dt5 == null)
            {

                MessageBox.Show("No Cars found with this Price Range");

                dataGridView1.DataSource = dt5;
                dataGridView1.Refresh();


                //By omar Ibra and Madboulyyyyyyyyy :)))
                this.Close();

                BuyOrRent b = new BuyOrRent(flag, buyerssn);
                b.Show();

                

            }
            else
            {

                dataGridView1.DataSource = dt5;
                dataGridView1.Refresh();

                VIN_comboBox.DataSource = dt5;
                VIN_comboBox.DisplayMember = "Vin";

                //MessageBox.Show("Cars found");



            }

           



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Company_comboBox.Enabled = false;
            Model_comboBox.Enabled = false;
            Year_comboBox.Enabled = false;

            PriceRange_comboBox.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Company_comboBox.Enabled = true;
            Model_comboBox.Enabled = true;
            Year_comboBox.Enabled = true;

            PriceRange_comboBox.Enabled = false;
        }
    }
}

