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
    public partial class Customer_LoginForm : Form
    {
        HomeAppliance_DataSetTableAdapters.CustomerTableAdapter H_ct = new HomeAppliance_DataSetTableAdapters.CustomerTableAdapter();

        private int loginCounts = 0;
        public static string CustomerID, CustomerName, CustomerNRC, CustomerAddress;
        public static Image CustomerProfilePic;
        

        public Customer_LoginForm()
        {
            InitializeComponent();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Validation on login
        private void btnCLogin_Click(object sender, EventArgs e)
        {
            
            if (loginCounts == 2)
            {
                MessageBox.Show("Login Fails 3 times! You have reach your limit!");
                Main_LogInForm MLF = new Main_LogInForm();
                MLF.Show();
                this.Hide();
            }
            else if (txtCEmail.Text == "")
            {
                MessageBox.Show("Please enter email address");
            }
            else if (txtCPassword.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
            else
            {
                DataTable h_dtC = new DataTable();
                h_dtC = H_ct.Customer_Login(txtCEmail.Text, txtCPassword.Text);

                if (h_dtC.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful.");

                    dgvClogin.DataSource = h_dtC;
                    CustomerID = dgvClogin[0, 0].Value.ToString();
                    CustomerName = dgvClogin[1, 0].Value.ToString();
                    CustomerNRC = dgvClogin[5, 0].Value.ToString();
                    CustomerAddress = dgvClogin[8, 0].Value.ToString();
                    CustomerProfilePic = Image.FromFile(dgvClogin[9, 0].Value.ToString());

                    Customer_Home CH = new Customer_Home();
                    CH.Show();
                    this.Hide();

                }
                else
                {
                    loginCounts += 1;
                        MessageBox.Show("Invalid Login! Login attempt : " + loginCounts);
                }
            }
        }
        //Reset 
        private void btnCReset_Click(object sender, EventArgs e)
        {
            txtCEmail.Clear();
            txtCPassword.Clear();
        }

        private void linkCsignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer CSU = new Customer();
            CSU.Show();
            this.Hide();
        }

        private void btnCBack_Click(object sender, EventArgs e)
        {
            Main_LogInForm ml = new Main_LogInForm();
            ml.Show();
            this.Hide();
        }

        
    }
}
