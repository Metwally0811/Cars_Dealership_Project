using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Admin
{
    public partial class AdminFunctionalities : Form
    {
        public AdminFunctionalities()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            AddAdmin AddA = new AddAdmin();
            AddA.Show();

            this.Close();

            
        }

        private void ApproveCar_button_Click(object sender, EventArgs e)
        {
            CarsRequests CReq = new CarsRequests();
            CReq.Show();

            this.Close();
        }

        private void WhareHouse_button_Click(object sender, EventArgs e)
        {
            AddToWhareHouse AddW = new AddToWhareHouse();
            AddW.Show();

            this.Close();
        }
    }
}
