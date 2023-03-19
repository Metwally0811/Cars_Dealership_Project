using Cars_Dealership_DBProject.Admin;
using Cars_Dealership_DBProject.Buyer;
using Cars_Dealership_DBProject.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            Admin_Login ALog = new Admin_Login();
            ALog.Show();

            



        }

        private void Seller_button_Click(object sender, EventArgs e)
        {
            Seller_Login Slog = new Seller_Login();
            Slog.Show();

            

        }

        private void Buyer_button_Click(object sender, EventArgs e)
        {
            Buyer_Login Blog = new Buyer_Login();
            Blog.Show();

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
