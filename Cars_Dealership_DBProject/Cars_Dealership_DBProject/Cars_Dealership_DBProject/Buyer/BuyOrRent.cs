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
    public partial class BuyOrRent : Form
    {
        public BuyOrRent()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            BuyerFunctinalities Bfun3 = new BuyerFunctinalities();
            Bfun3.Show();

            this.Close();
        }

        private void Rent_button_Click(object sender, EventArgs e)
        {
            // Hyro7 le form el transaction

            Payment pay = new Payment();
            pay.Show();

            this.Close();

        }

        private void Buy_button_Click(object sender, EventArgs e)
        {

            Payment pay1 = new Payment();
            pay1.Show();

            this.Close();

        }
    }
}
