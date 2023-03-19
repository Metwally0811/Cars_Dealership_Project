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
   
    public partial class AdminFunctionalities : Form
    {
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
        public AdminFunctionalities()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            AddAdmin AddA = new AddAdmin();
            AddA.Show();

            this.Close();

            
        }

        private void ApproveCar_button_Click(object sender, EventArgs e)
        {
            CarsRequests CReq = new CarsRequests();
            CReq.Show();

            this.Close();
        }

        private void WhareHouse_button_Click(object sender, EventArgs e)
        {
            AddToWhareHouse AddW = new AddToWhareHouse();
            AddW.Show();

            this.Close();
        }

        private void Retrive_Rented_Cars_Click(object sender, EventArgs e)
        {
            Rented_Cars rc = new Rented_Cars();
            rc.Show();

            this.Close();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Admin_Login A = new Admin_Login();
            A.Show();

            this.Close();
        }

        private void ViewStat_button_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            s.Show();

            this.Close();
        }
    }
}
