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
    public partial class BuyerFunctinalities : Form
    {
        public BuyerFunctinalities()
        {
            InitializeComponent();
        }

        private void ViewPastTrans_button_Click(object sender, EventArgs e)
        {
            ViewPastTransactions Vt = new ViewPastTransactions();
            Vt.Show();

            this.Close();
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            // hayfta7 el form de lel buyer fa lazem a disable el rent

            BuyOrRent BR = new BuyOrRent(); // overload 0
            BR.Show();

            this.Close();
        }

        private void Rent_button_Click(object sender, EventArgs e)
        {

            // hayfta7 el form de lel seller fa lazem a disable el buy
            

            BuyOrRent BR = new BuyOrRent(); // overload 1
            BR.Show();

            this.Close();

        }
    }
}
