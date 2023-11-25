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
    public partial class Admin_Sign_Up : Form
    {
        HomeAppliance_DataSetTableAdapters.AdministratorTableAdapter objHAdmin = new HomeAppliance_DataSetTableAdapters.AdministratorTableAdapter();
        DataTable dtHAdmin = new DataTable();
        
        
        public Admin_Sign_Up()
        {
            InitializeComponent();
            

            dtHAdmin = objHAdmin.GetData();
            dgvASignUp.DataSource = dtHAdmin;
            dgvASignUp.Refresh();

        }

   
        //AutoID Method
        public void AutoID_A()
        {
            DataTable dtAuto = new DataTable();
            dtAuto = objHAdmin.GetData();
            if (dtAuto.Rows.Count == 0)
            {
                txtAdID.Text = "A_001";
            }
            else
            {
                int IDsize = dtAuto.Rows.Count - 1;
                string oldAutoID = dtAuto.Rows[IDsize][0].ToString();
                int newAutoID = Convert.ToInt32(oldAutoID.Substring(2, 3));

                if (newAutoID >= 1 && newAutoID < 9)
                {
                    txtAdID.Text = "A_00" + (newAutoID + 1);
                }
                else if (newAutoID >= 9 && newAutoID < 99)
                {
                    txtAdID.Text = "A_0" + (newAutoID + 1);
                }
                else 
                {
                    txtAdID.Text = "A_" + (newAutoID + 1);
                }
            }
        }

        //Clear textbox method
        public void ResetA()
        {
            txtAName.Clear();
            txtAEmail.Clear();
            txtAPassword.Clear();
            txtAPhone.Clear();
            txtANRC.Clear();
            cboAPosition.SelectedIndex = -1;
            txtAAddress.Clear();
            pbAdmin.Image = null;
            dtaAdmin.Value = DateTime.Now;

        }

       //Call reset method in reset button
        private void btnAReset_Click(object sender, EventArgs e)
        {
            ResetA();
        }
        
        //Saving the data from users
        private void btnASave_Click(object sender, EventArgs e)
        {
            string AUsername = txtAName.Text;
            string APassword = txtAPassword.Text;

            //Validator Username
            if (txtAName.Text == "")
            {
                MessageBox.Show("Please enter the username!");
                txtAName.Focus();
            }
            else if (!AUsername.Any(char.IsLetterOrDigit))
            {
                MessageBox.Show(" UserName can only contain letters and numbers!");
                txtAName.Focus();
            }
            
            else if (txtAEmail.Text == "")
            {
                MessageBox.Show("Please enter the email");
                txtAEmail.Focus();
            }
            //validator password
            else if (txtAPassword.Text == "")
            {
                MessageBox.Show("Please enter the password");
                txtAPassword.Focus();
            }
            else if (APassword.Length < 8 || APassword.Length > 16)
            {
                MessageBox.Show("Password'slength should only be betweeen 8 and 16 characters.");
                txtAPassword.Focus();
            }
            else if (!APassword.Any(char.IsUpper))
            {
                MessageBox.Show("Password should contain at least one upper letter");
                txtAPassword.Focus();
            }
            else if (!APassword.Any(char.IsLower))
            {
                MessageBox.Show("Password should contain at least one lower letter");
                txtAPassword.Focus();
            }
            
            else
            {
                string Apiclocation = "D:\\L4DC\\DDOCP\\KHINE ZAR THWIN_P00198299_DDOCP_GA\\Data Base\\HomeAppliance_RentalSystem\\HomeAppliance_RentalSystem\\bin\\Debug\\PIC";
                 string ApicPath = Path.Combine(Apiclocation, txtAName.Text + ".jpg");
                 Image pA = pbAdmin.Image;
                 pA.Save(ApicPath);
               
                  Administrator_Model amH = new Administrator_Model();

                    amH.AdminID = txtAdID.Text;
                    amH.AdminName = txtAName.Text;
                    amH.AdminPhone = txtAPhone.Text;
                    amH.AdminEmail = txtAEmail.Text;
                    amH.AdminPassword = txtAPassword.Text;
                    amH.AdminNRC = txtANRC.Text;
                    amH.AdminDOB = dtaAdmin.Text;
                    amH.AdminPosition = cboAPosition.SelectedItem.ToString();
                    amH.AdminAddress = txtAAddress.Text;



                    objHAdmin.Insert(amH.AdminID, amH.AdminName, amH.AdminPhone, amH.AdminEmail, amH.AdminPassword, amH.AdminNRC, amH.AdminDOB, amH.AdminPosition, amH.AdminAddress, ApicPath);
                    MessageBox.Show("You have sign up completely! 😊 ");

                    
                    ResetA();
                    AutoID_A();
                    
                    dgvASignUp.DataSource = objHAdmin.GetData();
                    dgvASignUp.Refresh();
                    

                }
            }


        //To exit the program from using label X
        private void lblExiit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //Values on DataGirdView
        private void dgvASignUp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
               
                DataGridViewRow ARow = this.dgvASignUp.Rows[e.RowIndex];

                txtAdID.Text = ARow.Cells[0].Value.ToString();
                txtAName.Text = ARow.Cells[1].Value.ToString();
                txtAPhone.Text = ARow.Cells[2].Value.ToString();
                txtAEmail.Text = ARow.Cells[3].Value.ToString();
                txtAPassword.Text = ARow.Cells[4].Value.ToString();
                txtANRC.Text = ARow.Cells[5].Value.ToString();
                dtaAdmin.Text = ARow.Cells[6].Value.ToString();
                cboAPosition.SelectedItem = ARow.Cells[7].Value.ToString();
                txtAAddress.Text = ARow.Cells[8].Value.ToString();
                pbAdmin.Image = Image.FromFile(ARow.Cells[9].Value.ToString());

                
            }
            catch(Exception)
            {
                MessageBox.Show("Argument out of range!");
                return;
            }
 
            btnADelete.Enabled = true;
            btnASave.Enabled = false;
           
        }

        private void btnADelete_Click(object sender, EventArgs e)
        {
            if (txtAdID.Text == " ")
            {
                MessageBox.Show(" Invalid Administrator's ID!");
                txtAdID.Focus();
            }
            else
            {
                DialogResult drA = MessageBox.Show("Are you sure to delete this data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (drA.Equals(DialogResult.OK))
                {
                    objHAdmin.DeleteAdmin(txtAdID.Text);
                    MessageBox.Show("Successfully Deleted!");

                    dgvASignUp.DataSource = objHAdmin.GetData();
                    dgvASignUp.Refresh();
                    ResetA();
                    AutoID_A();

                    btnADelete.Enabled = false;
                    btnASave.Enabled = true;
                }
                
            }
        }


        //Choose Image from file and Show this image
        private void pbApic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openA = new OpenFileDialog();
            PictureBox pA = sender as PictureBox;

            if (pA != null)
            {
                openA.Filter = "(*.jpeg; *.jpg;*.png) | *.jpeg; *.jpg;*.png";
                if (openA.ShowDialog() == DialogResult.OK)
                {
                    pA.Image = Image.FromFile(openA.FileName);
                }
            }
        }

        private void Admin_Sign_Up_Load(object sender, EventArgs e)
        {

            AutoID_A();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_LoginForm Al = new Admin_LoginForm();
            Al.Show();
            this.Hide();
        }  
        
    }
}
