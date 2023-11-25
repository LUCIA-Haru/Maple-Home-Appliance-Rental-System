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
    public partial class Brand_Entry : Form
    {
        HomeAppliance_DataSetTableAdapters.BrandTableAdapter objHBrand = new HomeAppliance_DataSetTableAdapters.BrandTableAdapter();
        DataTable dtHBrand = new DataTable();

        public Brand_Entry()
        {
            InitializeComponent();
            AutoID_B();

            dtHBrand = objHBrand.GetData();
            dgvBrand.DataSource = dtHBrand;
            dgvBrand.Refresh();
        }

        //AutoID
        public void AutoID_B()
        {
            DataTable dtAuto = new DataTable();
            dtAuto = objHBrand.GetData();
            if (dtAuto.Rows.Count == 0)
            {
                txtBrID.Text = "B_001";
            }
            else
            {
                int IDsize = dtAuto.Rows.Count - 1;
                string oldAutoID = dtAuto.Rows[IDsize][0].ToString();
                int newAutoID = Convert.ToInt32(oldAutoID.Substring(2, 3));

                if (newAutoID >= 1 && newAutoID < 9)
                {
                    txtBrID.Text = "B_00" + (newAutoID + 1);
                }
                else if (newAutoID >= 9 && newAutoID < 99)
                {
                    txtBrID.Text = "B_0" + (newAutoID + 1);
                }
                else
                {
                    txtBrID.Text = "B_" + (newAutoID + 1);
                }
            }
        }
        //Reset
        public void ResetB()
        {
           
            txtBrName.Clear();
        }



        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Call reset method in reset button
        private void btnBReset_Click(object sender, EventArgs e)
        {
            ResetB();
        }

        private void btnBSave_Click(object sender, EventArgs e)
        {
            //Validator
            if (txtBrName.Text == " ")
            {
                MessageBox.Show("Please enter the brand name!");
            }
            else
            {
                Brand_Model bmH = new Brand_Model();

                bmH.BrandID = txtBrID.Text;
                bmH.BrandName = txtBrName.Text;

                objHBrand.Insert(bmH.BrandID, bmH.BrandName);
                MessageBox.Show("You have entered one brand! 😊 ");

                ResetB();
                AutoID_B();

                dgvBrand.DataSource = objHBrand.GetData();
                dgvBrand.Refresh();
            }

        }

        private void dgvBrand_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow BRow = this.dgvBrand.Rows[e.RowIndex];

                txtBrID.Text = BRow.Cells[0].Value.ToString();
                txtBrName.Text = BRow.Cells[1].Value.ToString();

                btnBUpdate.Enabled = true;
                btnBDelete.Enabled = true;
                btnBSave.Enabled = false;

            }
            catch (Exception)
            {

                MessageBox.Show("Argument out of range!");
                return;
            }
            
        }

        private void btnBDelete_Click(object sender, EventArgs e)
        {
            if (txtBrID.Text == " ")
            {
                MessageBox.Show(" Invalid Brand's ID!");
                txtBrID.Focus();
            }
            else
            {
                DialogResult drA = MessageBox.Show("Are you sure to delete this data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (drA.Equals(DialogResult.OK))
                {
                    objHBrand.DeleteBrand(txtBrID.Text);
                    MessageBox.Show("Successfully Deleted!");

                    dgvBrand.DataSource = objHBrand.GetData();
                    dgvBrand.Refresh();

                    ResetB();
                    AutoID_B();

                    btnBUpdate.Enabled = false;
                    btnBDelete.Enabled = false;
                    btnBSave.Enabled = true;
                }
            }
        }

        private void btnBUpdate_Click(object sender, EventArgs e)
        {
            if (txtBrName.Text == "")
            {
                MessageBox.Show(" Invalid Brand's Name!");
                txtBrName.Focus();
            }
            else
            {
                objHBrand.UpdateBrand(txtBrName.Text, txtBrID.Text);
                MessageBox.Show("The informations are updated successfully.");

                dgvBrand.DataSource = objHBrand.GetData();
                    dgvBrand.Refresh();

                    ResetB();
                    AutoID_B();

                    btnBUpdate.Enabled = false;
                    btnBDelete.Enabled = false;
                    btnBSave.Enabled = true;
                
            }
        }


        private void Brand_Entry_Load(object sender, EventArgs e)
        {
            btnBUpdate.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Home AH = new Admin_Home();
            AH.Show();
            this.Hide();
        }

        
    }
}
