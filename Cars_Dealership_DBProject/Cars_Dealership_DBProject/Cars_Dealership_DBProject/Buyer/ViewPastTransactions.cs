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
    public partial class ViewPastTransactions : Form
    {
        public ViewPastTransactions()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            BuyerFunctinalities Bfun2 = new BuyerFunctinalities();
            Bfun2.Show();

            this.Close();
        }
    }
}
