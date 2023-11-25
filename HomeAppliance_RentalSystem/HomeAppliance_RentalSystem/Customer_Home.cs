using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAppliance_RentalSystem
{
    public partial class Customer_Home : Form

    {

        public Customer_Home()
        {
            InitializeComponent();

            pbCImage.Image = Customer_LoginForm.CustomerProfilePic;
            lblCHomeName.Text = Customer_LoginForm.CustomerName;
            
        }

        

        private void lblX_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer_LoginForm CLF = new Customer_LoginForm();
            CLF.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Renting RR = new Renting();
            RR.Show();
            this.Hide();
        }


        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Reports vv = new Reports();
            vv.Show();
            this.Hide();
        }

        private void btnCSearch_Click(object sender, EventArgs e)
        {
            Customer_Search Cs = new Customer_Search();
            Cs.Show();
            this.Hide();
        }
    }
}
