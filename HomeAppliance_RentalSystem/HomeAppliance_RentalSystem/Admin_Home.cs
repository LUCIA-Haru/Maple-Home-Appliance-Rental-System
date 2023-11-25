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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();

            lblAHName.Text = Admin_LoginForm.AdminName;
            pbAimg.Image = Admin_LoginForm.AdminProfilePic;
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_LoginForm ALF = new Admin_LoginForm();
            ALF.Show();
            this.Hide();
        }

        private void btnBrandEntry_Click(object sender, EventArgs e)
        {
            Brand_Entry BE = new Brand_Entry();
            BE.Show();
            this.Hide();
        }

        private void btnCategoryEntry_Click(object sender, EventArgs e)
        {
            Category_Entry CE = new Category_Entry();
            CE.Show();
            this.Hide();
        }

        private void btnApEntry_Click(object sender, EventArgs e)
        {
            Appliances AA = new Appliances();
            AA.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Searching_Appliances SA = new Searching_Appliances();
            SA.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reports Rs = new Reports();
            Rs.Show();
            this.Hide();
        }
    }
}
