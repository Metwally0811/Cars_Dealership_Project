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
    public partial class ViewCars : Form
    {
        public ViewCars()
        {
            InitializeComponent();
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
    }
}
