using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Seller
{

    public partial class Seller_Login : Form
    {
        public Seller_Login()
        {
            InitializeComponent();
        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            SignIn Sin = new SignIn();
            Sin.Show();

            this.Close();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            SignUp Sup = new SignUp();
            Sup.Show();

            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
