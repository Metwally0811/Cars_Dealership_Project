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
    public partial class SignUpBuyer : Form
    {
        public SignUpBuyer()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Buyer_Login Blog = new Buyer_Login();
            Blog.Show();

            this.Close();

        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            // if signup successful go to next form
            BuyerFunctinalities Bfun1 = new BuyerFunctinalities();
            Bfun1.Show();

            this.Close();
        }
    }
}
