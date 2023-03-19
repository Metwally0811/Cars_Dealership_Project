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
    public partial class SignInBuyer : Form
    {
        public SignInBuyer()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Buyer_Login Blog2 = new Buyer_Login();
            Blog2.Show();

            this.Close();
        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            // Check for username and password and if true go to next form

            BuyerFunctinalities Bfun = new BuyerFunctinalities();
            Bfun.Show();

            this.Close();

        }
    }
}
