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
    public partial class Admin_LoginForm : Form
    {
        HomeAppliance_DataSetTableAdapters.AdministratorTableAdapter H_at = new HomeAppliance_DataSetTableAdapters.AdministratorTableAdapter();

        private int loginCounts = 0;
        public static string AdminID, AdminName;
        public static Image AdminProfilePic;
       
        public Admin_LoginForm()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Validation on login
        private void btnALogin_Click(object sender, EventArgs e)
        {
            if (loginCounts == 2)
            {
                MessageBox.Show("Login Fails 3 times! You have reach your limit!");
                Main_LogInForm MLF = new Main_LogInForm();
                MLF.Show();
                this.Hide();
            }
            else if (txtAEmail.Text == "")
            {
                MessageBox.Show("Please enter email address");
            }
            else if (txtAPassword.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                DataTable h_dtA = new DataTable();
                h_dtA = H_at.Admin_Login(txtAEmail.Text, txtAPassword.Text);

                if (h_dtA.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful.");

                    dgvALogin.DataSource = h_dtA;
                    AdminID = dgvALogin[0,0].Value.ToString();
                    AdminName = dgvALogin[1,0].Value.ToString();
                    AdminProfilePic = Image.FromFile(dgvALogin[9,0].Value.ToString());

                    Admin_Home AH = new Admin_Home();
                    AH.Show();
                    this.Hide();
                }
                else
                {
                    loginCounts += 1;
                    MessageBox.Show("Invalid Login! Login attempt : " + loginCounts);
                }
            }
        }
        //Rest all data on Login form
        private void btnAReset_Click(object sender, EventArgs e)
        {
            txtAEmail.Clear();
            txtAPassword.Clear();
        }

        private void linkASignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Sign_Up ASU = new Admin_Sign_Up();
            ASU.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_LogInForm ml = new Main_LogInForm();
            ml.Show();
            this.Hide();
        }

    }
}
