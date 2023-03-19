using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Buyer
{
    public partial class Buyer_Login : Form
    {
        public Buyer_Login()
        {
            InitializeComponent();
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
    }
}
