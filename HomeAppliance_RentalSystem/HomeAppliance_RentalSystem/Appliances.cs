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
    public partial class Appliances : Form
    {
        HomeAppliance_DataSetTableAdapters.AppliancesTableAdapter objHApp = new HomeAppliance_DataSetTableAdapters.AppliancesTableAdapter();
        DataTable dtApp = new DataTable();
        //BRand
        HomeAppliance_DataSetTableAdapters.BrandTableAdapter objHBr = new HomeAppliance_DataSetTableAdapters.BrandTableAdapter();
        //Category
        HomeAppliance_DataSetTableAdapters.CategoryTableAdapter objHCa = new HomeAppliance_DataSetTableAdapters.CategoryTableAdapter();
        //Admin
        HomeAppliance_DataSetTableAdapters.AdministratorTableAdapter objHAdmin = new HomeAppliance_DataSetTableAdapters.AdministratorTableAdapter();
        
        public Appliances()
        {
            InitializeComponent();

            Reset_Ap();
            AutoID_Ap();
            BrandNameInfo();
            CategoryNameinfo();

            dtApp = objHApp.GetData();
            dgvApp.DataSource = dtApp;
            dgvApp.Refresh();
        }

        //AutoID
        public void AutoID_Ap()
        {
            DataTable dtAuto = new DataTable();
            dtAuto = objHApp.GetData();
            if (dtAuto.Rows.Count == 0)
            {
                txtAppID.Text = "Ap_001";
            }
            else
            {
                int IDsize = dtAuto.Rows.Count - 1;
                string oldAutoID = dtAuto.Rows[IDsize][0].ToString();
                int newAutoID = Convert.ToInt32(oldAutoID.Substring(3, 3));

                if (newAutoID >= 1 && newAutoID < 9)
                {
                    txtAppID.Text = "Ap_00" +(newAutoID + 1);
                }
                else if (newAutoID >= 9 && newAutoID < 99)
                {
                    txtAppID.Text = "Ap_0" +(newAutoID + 1);
                }
                else
                {
                    txtAppID.Text = "Ap_" +(newAutoID + 1);
                }
            }
        }
        //Choose Image from file and Show this image
        private void pbApppic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openApp = new OpenFileDialog();
            PictureBox pApp = sender as PictureBox;

            if (pApp != null)
            {
                openApp.Filter = "(*.jpeg; *.jpg;*.png, *.webp) | *.jpeg; *.jpg;*.png: *.webp";
                if (openApp.ShowDialog() == DialogResult.OK)
                {
                    pApp.Image = Image.FromFile(openApp.FileName);
                }
            }
        }

        //Saving the data from users
        private void btnAppSave_Click(object sender, EventArgs e)
        {
            if (txtAppName.Text == "")
            {
                MessageBox.Show("Please enter the name!");
            }
            else if (cboBName.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose the brand!");
            }
            else if( cboCName.SelectedIndex  == 0)
            {
                MessageBox.Show("Please choose the category!");
            }
            
            else if (txtMFee.Text == "")
                {
                MessageBox.Show("Please enter the fee");
            }
            else if (txtAppQuantity.Text == "")
            {
                MessageBox.Show("Please enter the quantity");
            }
            else if (txtAppStatus.Text == "")
            {
                MessageBox.Show("Please enter the Status");
            }
           
           
            else
            {
                string AppPiclocation = "D:\\L4DC\\DDOCP\\KHINE ZAR THWIN_P00198299_DDOCP_GA\\Data Base\\HomeAppliance_RentalSystem\\HomeAppliance_RentalSystem\\bin\\Debug\\PIC";
                string ApPicPath = Path.Combine(AppPiclocation, txtAppName.Text + ".jpg");
                Image AppPic = pbAppImage.Image;
                AppPic.Save(ApPicPath);

                Appliances_Model amAp = new Appliances_Model();

                
                amAp.AppliancesID= txtAppID.Text;
                amAp.AppliancesName = txtAppName.Text;
                amAp.BrandID = cboBName.SelectedValue.ToString();
                amAp.CategoryID = cboCName.SelectedValue.ToString();
                amAp.Model = txtAppModel.Text;
                amAp.Colour = txtColour.Text;
                amAp.Dimensions = txtDimesions.Text;
                amAp.EnergyConsumption =txtEC.Text;
                amAp.MonthlyFee = txtMFee.Text;
                amAp.AppliancesQuantity = txtAppQuantity.Text;
                amAp.AppliancesStatus = txtAppStatus.Text;
                amAp.AdminID = Admin_LoginForm.AdminID;

                
                decimal amAPFee = decimal.Parse(amAp.MonthlyFee);
                int amApQuantity = int.Parse(amAp.AppliancesQuantity);

                objHApp.Insert(amAp.AppliancesID, amAp.AppliancesName, amAp.BrandID, amAp.CategoryID, amAp.Model, amAp.Colour, amAp.Dimensions, amAp.EnergyConsumption, amAPFee, amApQuantity, amAp.AppliancesStatus, ApPicPath, amAp.AdminID);
                MessageBox.Show("You have entered one appliance successfully.");
                Reset_Ap();
                AutoID_Ap();

                dgvApp.DataSource = objHApp.GetData();
                dgvApp.Refresh();
            }
        }

        //Brand Combo Box
        public void BrandNameInfo()
        {
            DataTable dtBName = new DataTable();

            dtBName = objHBr.GetData();
            int RowsCount = dtBName.Rows.Count;

            if (RowsCount > 0)
            {
                //Add default row to DataTable
                DataRow defaultRow = dtBName.NewRow();
                defaultRow["BrandID"] = -1;
                defaultRow["BrandName"] = "To choose the brand";
                dtBName.Rows.InsertAt(defaultRow, 0);

                //Bind DataTable to ComboBox
                DataRow drBr = dtBName.NewRow();
                cboBName.DataSource = dtBName;
                cboBName.DisplayMember = "BrandName";
                cboBName.ValueMember = "BrandID";
            }
        }
        //Category Combo Box
        public void CategoryNameinfo()
        {
            DataTable dtCaName = new DataTable();

            dtCaName = objHCa.GetData();
            int RowsCount = dtCaName.Rows.Count;

            if (RowsCount > 0)
            {
                //Add default row to DataTable
                DataRow defaultRow = dtCaName.NewRow();
                defaultRow["CategoryID"] = -1;
                defaultRow["CategoryName"] = "To choose the Category";
                dtCaName.Rows.InsertAt(defaultRow, 0);

                //Bind DataTable to ComboBox
                DataRow drCa = dtCaName.NewRow();
                cboCName.DataSource = dtCaName;
                cboCName.DisplayMember = "CategoryName";
                cboCName.ValueMember = "CategoryID";

            }
        }
  


        //Values on DataGirdView

        private void dgvApp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow AppRow = this.dgvApp.Rows[e.RowIndex];

                txtAppID.Text = AppRow.Cells[0].Value.ToString();
                txtAppName.Text = AppRow.Cells[1].Value.ToString();
                cboBName.SelectedValue = AppRow.Cells[2].Value.ToString();
                cboCName.SelectedValue = AppRow.Cells[3].Value.ToString();
                txtAppModel.Text = AppRow.Cells[4].Value.ToString();
                txtColour.Text = AppRow.Cells[5].Value.ToString();
                txtDimesions.Text = AppRow.Cells[6].Value.ToString();
                txtEC.Text = AppRow.Cells[7].Value.ToString();
                txtMFee.Text = AppRow.Cells[8].Value.ToString();
                txtAppQuantity.Text = AppRow.Cells[9].Value.ToString();
                txtAppStatus.Text = AppRow.Cells[10].Value.ToString();
                pbAppImage.Image = Image.FromFile(AppRow.Cells[11].Value.ToString());
                lblAdminID.Text = AppRow.Cells[12].Value.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Argument out of range!");
                return;
            }
            btnAppDelete.Enabled = true;
            btnAppUpdate.Enabled = true;
            btnAppSave.Enabled = false;
            btnAppReset.Enabled = false;
        }


        //Reset Data
        public void Reset_Ap()
        {
            txtAppName.Clear();
            cboBName.SelectedValue = -1;
            cboCName.SelectedValue = -1;
            txtAppModel.Clear();
            txtColour.Clear();
            txtDimesions.Clear();
            txtAppQuantity.Clear();
            txtEC.Clear();
            txtMFee.Clear();
            txtAppStatus.Clear();
            pbAppImage.Image = null;

        }
        private void btnAppReset_Click(object sender, EventArgs e)
        {
            Reset_Ap();
        }


        //Update
        private void btnAppUpdate_Click(object sender, EventArgs e)
        {
            if (txtAppName.Text == " ")
            {
                MessageBox.Show("Please enter Appliances'Name.");
                txtAppName.Focus();
            }
            else
            {
                
                decimal fee = decimal.Parse(txtMFee.Text);
                int Quantity = int.Parse(txtAppQuantity.Text);
                
                objHApp.UpdateAppliances(txtAppName.Text, cboBName.SelectedValue.ToString(), cboCName.SelectedValue.ToString(), txtAppModel.Text, txtColour.Text, txtDimesions.Text, txtEC.Text, fee, Quantity, txtAppStatus.Text, Admin_LoginForm.AdminID, txtAppID.Text);
                MessageBox.Show("The informations are updated successfully.");

                dgvApp.DataSource = objHApp.GetData();
                dgvApp.Refresh();

                Reset_Ap();
                AutoID_Ap();

                btnAppDelete.Enabled = false;
                btnAppUpdate.Enabled = true;
                btnAppSave.Enabled = true;
                btnAppReset.Enabled = true;

            }
        }

        //Delete
        private void btnAppDelete_Click(object sender, EventArgs e)
        {
            if (txtAppID.Text == " ")
            {
                MessageBox.Show(" Invalid ID!");
                txtAppID.Focus();

            }
            else
            {
                DialogResult drA = MessageBox.Show("Are you sure to delete this data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (drA.Equals(DialogResult.OK))
                {
                    objHApp.DeleteAppliances(txtAppID.Text);
                    MessageBox.Show("Successfully Deleted!");

                    dgvApp.DataSource = objHApp.GetData();
                    dgvApp.Refresh();

                    Reset_Ap();
                    AutoID_Ap();

                    btnAppDelete.Enabled = false;
                    btnAppUpdate.Enabled = false;
                    btnAppSave.Enabled = true;
                    btnAppReset.Enabled = true;

                }
            }
        }


        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Home AH = new Admin_Home();
            AH.Show();
            this.Hide();
        }

        private void Appliances_Load(object sender, EventArgs e)
        {
            btnAppUpdate.Enabled = false;
            //txtAppQuantity.Text = "1";
            lblAdminID.Text = Admin_LoginForm.AdminID;
        }

        
        
    }
}
