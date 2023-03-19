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
    public partial class ViewPastTransactions : Form
    {
        int Buy_ssn;
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
        public ViewPastTransactions(int Bssn)
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            Buy_ssn = Bssn;
            controllerObj = new Controller();   
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            BuyerFunctinalities Bfun2 = new BuyerFunctinalities(Buy_ssn);
            Bfun2.Show();

            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ViewPastTrans_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //OD baload el grid view be el rented cars aw el bought 3la hasab ekhtaro mn el combobox
            if (ViewBorR_comboBox.Text== "Bought Cars")
            {
                //query trg3ly el cars ely el buyer eshtrahom 3la hasab el ssn bta3o
                dt = controllerObj.Bought_Cars_with_SsN(Buy_ssn);

                if(dt == null)
                {
                    MessageBox.Show("No Cars were Bought");


                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();

                }
                else
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                }
               

            }
            else
            {
                dt = controllerObj.Rented_Cars_with_SsN(Buy_ssn);
                if (dt == null)
                {
                    MessageBox.Show("No Cars are currently Rented");
                    
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();

                }
                else
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                }

               

            }

        }

        private void ViewBorR_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}