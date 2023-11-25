using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAppliance_RentalSystem
{
    public partial class Main_LogInForm : Form
    {
        public Main_LogInForm()
        {
            InitializeComponent();
        }
       
        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin_LoginForm ALF = new Admin_LoginForm();
            ALF.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer_LoginForm CLF = new Customer_LoginForm();
            CLF.Show();
            this.Hide();
        }

    }
}
