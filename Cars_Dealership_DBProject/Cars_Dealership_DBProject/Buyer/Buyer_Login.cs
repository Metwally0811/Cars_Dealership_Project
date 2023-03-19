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
    public partial class Buyer_Login : Form
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
        public Buyer_Login()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            ViewCars Vc = new ViewCars();
            Vc.Show();

            this.Close();
        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            SignInBuyer SinB = new SignInBuyer();
            SinB.Show();

            this.Close();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            SignUpBuyer SupB = new SignUpBuyer();
            SupB.Show();

            this.Close();

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            //Welcome w = new Welcome();
            //w.Show();

            this.Close();
        }
    }
}
