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
    public partial class Category_Entry : Form
    {
        HomeAppliance_DataSetTableAdapters.CategoryTableAdapter objHCategory = new HomeAppliance_DataSetTableAdapters.CategoryTableAdapter();
        DataTable dtHCategory = new DataTable();
        public Category_Entry()
        {
            InitializeComponent();
            AutoID_Cat();

            dtHCategory = objHCategory.GetData();
            dgvCategory.DataSource = dtHCategory;
            dgvCategory.Refresh();
        }

        //Auto
        public void AutoID_Cat()
        {
            DataTable dtAuto = new DataTable();
            dtAuto = objHCategory.GetData();
            if (dtAuto.Rows.Count == 0)
            {
                txtCatID.Text = "Ca_001";
            }
            else
            {
                int IDsize = dtAuto.Rows.Count - 1;
                string oldAutoID = dtAuto.Rows[IDsize][0].ToString();
                int newAutoID = Convert.ToInt32(oldAutoID.Substring(3, 3));

                if (newAutoID >= 1 && newAutoID < 9)
                {
                    txtCatID.Text = "Ca_00" + (newAutoID + 1);
                }
                else if (newAutoID >= 9 && newAutoID < 99)
                {
                    txtCatID.Text = "Ca_0" + (newAutoID + 1);
                }
                else
                {
                    txtCatID.Text = "Ca_" + (newAutoID + 1);
                }
            }
        }
        
        //Reset
        public void ResetCa()
        {
           
            txtCatName.Clear();
        }
        //Call reset method in reset button
        private void btnCaReset_Click(object sender, EventArgs e)
        {
            ResetCa();
            
        }
        

        
        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Saving the data from users
        private void btnCaSave_Click(object sender, EventArgs e)
        {
           
            //vallidation
            if (txtCatName.Text == "")
            {
                MessageBox.Show("Please enter the Category Name!");
            }
            else
            {
                Category_Model cmH = new Category_Model();

                cmH.CategoryID = txtCatID.Text;
                cmH.CategoryName = txtCatName.Text;

                objHCategory.Insert(cmH.CategoryID, cmH.CategoryName);
                MessageBox.Show("You have entered one category successfully");

                ResetCa();
                AutoID_Cat();

                dgvCategory.DataSource = objHCategory.GetData();
                dgvCategory.Refresh();
            }
        }


        //Values on DataGirdView
        private void dgvCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow CaRow = this.dgvCategory.Rows[e.RowIndex];

                txtCatID.Text = CaRow.Cells[0].Value.ToString();
                txtCatName.Text = CaRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Argument out of range!");
                return;
            }
            btnCaUpdate.Enabled = true;
            btnCaDelete.Enabled = true;
            btnCaSave.Enabled = false;
        }

        private void btnCaDelete_Click(object sender, EventArgs e)
        {
            if (txtCatID.Text == " ")
            {
                MessageBox.Show("Invalid CategoryID!");
                txtCatID.Focus();
            }
            else
            {
                 DialogResult drA = MessageBox.Show("Are you sure to delete this data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                 if (drA.Equals(DialogResult.OK))
                 {
                     objHCategory.DeleteCategory(txtCatID.Text);
                     MessageBox.Show("Successfully Deleted!");

                     dgvCategory.DataSource = objHCategory.GetData();
                     dgvCategory.Refresh();
                     ResetCa();
                     AutoID_Cat();
                     
                     btnCaSave.Enabled = true;
                     btnCaUpdate.Enabled = false;
                     btnCaDelete.Enabled = false;
                 }
            }
        }

        private void btnCaUpdate_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text == " ")
            {
                MessageBox.Show("Please enter category name!");
                txtCatName.Focus();
            }
            else
            {
                objHCategory.UpdateCategory(txtCatName.Text, txtCatID.Text);
                MessageBox.Show("The informations are updated successfully.");

                dgvCategory.DataSource = objHCategory.GetData();
                dgvCategory.Refresh();
                ResetCa();
                AutoID_Cat();
                
                btnCaSave.Enabled = true;
                btnCaUpdate.Enabled = false;
                btnCaDelete.Enabled = false;
            }
        }

        private void Category_Entry_Load(object sender, EventArgs e)
        {
            btnCaUpdate.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Home AH = new Admin_Home();
            AH.Show();
            this.Hide();
        }
    }
}
