using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomeAppliance_RentalSystem
{
    public partial class Customer : Form
    {
        HomeAppliance_DataSetTableAdapters.CustomerTableAdapter objHCustomers = new HomeAppliance_DataSetTableAdapters.CustomerTableAdapter();
        DataTable dtHCustomers = new DataTable();

        public Customer()
        {
            InitializeComponent();
            
            //for datagridview
            dtHCustomers = objHCustomers.GetData();
            dgvCSignup.DataSource = dtHCustomers;
            dgvCSignup.Refresh();
        }



        //AutoID Method
        public void AutoID_C()
        {
            DataTable dtc = new DataTable();
            dtc = objHCustomers.GetData();

            if (dtc.Rows.Count == 0)
            {
                txtCID.Text = "C_001";
            }
            else
            {
                int Csize = dtc.Rows.Count - 1;
                string oldIDc = dtc.Rows[Csize][0].ToString();

                int newIDc = Convert.ToInt32(oldIDc.Substring(2,3));

                if (newIDc >= 1 && newIDc < 9)
                {
                    txtCID.Text = "C_00" + (newIDc + 1);
                }
                else if (newIDc >= 9 && newIDc < 99)
                {
                    txtCID.Text = "C_0" + (newIDc + 1);
                }
                else if (newIDc >= 99 && newIDc < 999)
                {
                    txtCID.Text = "C_" + (newIDc + 1);
                }
            }
        }

      
        //Clear Function
        public void ResetC()
        {
            txtCName.Clear();
            txtCPhone.Clear();
            txtCEmail.Clear();
            txtCNRC.Clear();
            txtCAddress.Clear();
            dtaCustomer.Value = DateTime.Now;
            txtCPassword.Clear();
            cbCGender.SelectedIndex = -1;
            pbCPic.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetC();
        }
        //Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            string CUserName = txtCName.Text;
            string Cpassword = txtCPassword.Text;

            //password
             if (txtCName.Text == "")
            {
                MessageBox.Show("Please enter the name!");
                txtCName.Focus();
            }
             else if (!CUserName.Any(char.IsLetterOrDigit))
            {
                MessageBox.Show(" UserName can only contain letters and numbers!");
                txtCName.Focus();
            }
             else if (txtCPassword.Text == "")
             {
                 MessageBox.Show("Please fill password!");
                 txtCPassword.Focus();
             }
            else if (Cpassword.Length < 8 || Cpassword.Length > 20)
            {
                MessageBox.Show("Password Length should between 8 and 20 characters");
                txtCPassword.Focus();

            }
            
            else if (!Cpassword.Any(char.IsUpper))
            {
                MessageBox.Show("Password should contain at least one upper letter");
                txtCPassword.Focus();
            }
            else if (!Cpassword.Any(char.IsLower))
            {
                MessageBox.Show("Password should contain at least one lower letter");
                txtCPassword.Focus();
            }
            
            else if (txtCEmail.Text == "")
            {
                MessageBox.Show("Please fill customer's email!");
                txtCEmail.Focus();
            }
             else if (txtCAddress.Text == "")
             {
                 MessageBox.Show("Please fill customer's address!");
                 
             }

             else
             {
                 string Cpiclocation = "D:\\L4DC\\DDOCP\\KHINE ZAR THWIN_P00198299_DDOCP_GA\\Data Base\\HomeAppliance_RentalSystem\\HomeAppliance_RentalSystem\\bin\\Debug\\PIC";
                 string Cpath = Path.Combine(Cpiclocation, txtCName.Text + ".jpg");
                 Image Ca = pbCPic.Image;
                 Ca.Save(Cpath);

                 Customer_Model cmc = new Customer_Model();
                 cmc.CustomerID = txtCID.Text;
                 cmc.CustomerName = txtCName.Text;
                 cmc.CustomerPhone = txtCPhone.Text;
                 cmc.CustomerEmail = txtCEmail.Text;
                 cmc.CustomerPassword = txtCPassword.Text;
                 cmc.CustomerNRC = txtCNRC.Text;
                 cmc.CustomerDOB = dtaCustomer.Text;
                 cmc.CustomerGender = cbCGender.SelectedItem.ToString();
                 cmc.CustomerAddress = txtCAddress.Text;

                 objHCustomers.Insert(cmc.CustomerID, cmc.CustomerName, cmc.CustomerPhone, cmc.CustomerEmail, cmc.CustomerPassword, cmc.CustomerNRC, cmc.CustomerDOB, cmc.CustomerGender, cmc.CustomerAddress, Cpath);
                 MessageBox.Show("You have sign up completely!. 😊");

                 ResetC();
                 AutoID_C();

                 dgvCSignup.DataSource = objHCustomers.GetData();
                 dgvCSignup.Refresh();


             }



        }

        //Values on DataGirdView
        private void dgvCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow c_row = this.dgvCSignup.Rows[e.RowIndex];

                txtCID.Text = c_row.Cells[0].Value.ToString();
                txtCName.Text = c_row.Cells[1].Value.ToString();
                txtCPhone.Text = c_row.Cells[2].Value.ToString();
                txtCEmail.Text = c_row.Cells[3].Value.ToString();
                txtCPassword.Text = c_row.Cells[4].Value.ToString();
                txtCNRC.Text = c_row.Cells[5].Value.ToString();
                dtaCustomer.Text = c_row.Cells[6].Value.ToString();
                cbCGender.SelectedItem = c_row.Cells[7].Value.ToString();
                txtCAddress.Text = c_row.Cells[8].Value.ToString();
                pbCPic.Image = Image.FromFile(c_row.Cells[9].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Argument out of range!");
                return;
            }

            btnCSave.Enabled = false;
        }
        //Choose Image from file and Show this image
        private void pbCpic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openC= new OpenFileDialog(); // open dialog to select pic
            PictureBox cpic = sender as PictureBox; //ahow pic

            if (cpic != null)
            {
                openC.Filter = "(*.jpeg; *.jpg;*.png) | *.jpeg; *.jpg;*.png";
                if (openC.ShowDialog() == DialogResult.OK)
                {
                    cpic.Image = Image.FromFile(openC.FileName);
                }
            }


        }

       
        private void Customer_Load(object sender, EventArgs e)
        {
            AutoID_C();
        }
        //To exit the program from using label X
        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer_LoginForm CL = new Customer_LoginForm();
            CL.Show();
            this.Hide();
        }


    }
    
}
