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
    public partial class ViewCars : Form
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
        public ViewCars()
        {
            InitializeComponent();
            controllerObj = new Controller();


            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            ViewCars_dataGridView.DataSource = controllerObj.SelectAllCarsInWareHouse();
            ViewCars_dataGridView.Refresh();

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Buyer_Login Blog1 = new Buyer_Login();
            Blog1.Show();

            this.Close();
        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            SignInBuyer SinB1 = new SignInBuyer();
            SinB1.Show();

            this.Close();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            SignUpBuyer SupB1 = new SignUpBuyer();
            SupB1.Show();

            this.Close();
        }

        private void ViewCars_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
