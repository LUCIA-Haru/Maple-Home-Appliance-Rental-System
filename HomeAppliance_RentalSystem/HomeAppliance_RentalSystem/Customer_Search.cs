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
    public partial class Customer_Search : Form
    {

        HomeAppliance_DataSetTableAdapters.AppliancesTableAdapter dsApp = new HomeAppliance_DataSetTableAdapters.AppliancesTableAdapter();
        HomeAppliance_DataSetTableAdapters.CategoryTableAdapter dsCategory = new HomeAppliance_DataSetTableAdapters.CategoryTableAdapter();
        HomeAppliance_DataSetTableAdapters.BrandTableAdapter dsBrand = new HomeAppliance_DataSetTableAdapters.BrandTableAdapter();
        DataTable dtApp = new DataTable();
        DataTable dtCat = new DataTable();
        DataTable dtEC = new DataTable();
        DataTable dt = new DataTable();
        //DataRow dhr;

        public Customer_Search()
        {
            InitializeComponent();
            SetCategoryName();
            SetEC();
            
        }
        public void ColumnVisible()
        {
            dgvSearch.Columns["AppliancesID"].Visible = false;
            dgvSearch.Columns["BrandID"].Visible = false;
            dgvSearch.Columns["CategoryID"].Visible = false;
            dgvSearch.Columns["AppliancesImage"].Visible = false;
            dgvSearch.Columns["AdminID"].Visible = false;
        }
        //Search By Category
        private void SetCategoryName()
        {
            dtCat = dsCategory.GetData();

            cboCategory.Items.Add("Choose Category Name");
            for (int i = 0; i < dtCat.Rows.Count; i++)
            {
                cboCategory.Items.Add(dtCat.Rows[i][1].ToString());
            }
            cboCategory.SelectedIndex = 0;
        }
     
        //Search by EC
        private void SetEC()
        {
            dtEC = dsApp.GetData();

            cboEC.Items.Add("Choose Energy Consumption Name");
            for (int j = 0; j < dtEC.Rows.Count; j++)
            {
                cboEC.Items.Add(dtEC.Rows[j][7].ToString());
            }
            cboEC.SelectedIndex = 0;
        }
        
        //Search by RentalFee
        private void SetRentalFee()
        {
            dtApp = dsApp.GetData();

            cboFee.Items.Add("Choose Rental Fee");
            for (int k = 0; k < dtApp.Rows.Count; k++)
            {
                cboFee.Items.Add(dtApp.Rows[k]["RentalFee"].ToString());
            }
            cboFee.SelectedIndex = 0;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            
            if (rdoASC.Checked || rdoDESC.Checked)
            {
                cboEC.SelectedIndex = 0;
                cboCategory.SelectedIndex = 0;
                cboFee.SelectedIndex = 0;

                if (rdoASC.Checked)
                {
                    dt = dsApp.GetDataByShowAll();
                    dgvSearch.DataSource = dt;
                    dgvSearch.Refresh();
                }
                else if (rdoDESC.Checked)
                {
                    dt = dsApp.GetDataBySHowAll_DESC();
                    dgvSearch.DataSource = dt;
                    dgvSearch.Refresh();
                }
                ColumnVisible();
            }
            else
            {
                MessageBox.Show("Please choose one of the radio buttons.");
            }

            

            
        }

        private void Customer_Search_Load(object sender, EventArgs e)
        {

            SetRentalFee();
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
                if (rdoASC.Checked || rdoDESC.Checked)
                {
                    if (rdoASC.Checked)
                    {
                        if (cboCategory.SelectedIndex > 0)
                        {
                            //category;
                            dt = dsApp.GetDataByCategory(cboCategory.SelectedItem.ToString());
                            dgvSearch.DataSource = dt;
                            dgvSearch.Refresh();
                        }
                        if (cboEC.SelectedIndex > 0)
                        {
                            //EC
                            DataTable dt2 = new DataTable();
                            dt2 = dsApp.GetDataByEC(cboEC.SelectedItem.ToString());
                            dgvSearch.DataSource = dt2;
                            dgvSearch.Refresh();
                        }

                        if (cboFee.SelectedIndex > 0)
                        {
                            //FEe
                            DataTable dt3 = new DataTable();
                            decimal fee = Convert.ToDecimal(cboFee.SelectedItem.ToString());
                            dt3 = dsApp.GetDataBySearchFee(fee);
                            dgvSearch.DataSource = dt3;
                            dgvSearch.Refresh();


                        }


                    }
                    else if (rdoDESC.Checked)
                    {
                        if (cboCategory.SelectedIndex > 0)
                        {
                            dt = dsApp.GetDataByCategory_DESC(cboCategory.SelectedItem.ToString());
                            dgvSearch.DataSource = dt;
                            dgvSearch.Refresh();
                        }

                        if (cboEC.SelectedIndex != 0)
                        {
                            DataTable dt2 = new DataTable();
                            dt2 = dsApp.GetDataByEC_DESC(cboEC.SelectedItem.ToString());
                            dgvSearch.DataSource = dt2;
                            dgvSearch.Refresh();
                        }
                        if (cboFee.SelectedIndex > 0)
                        {
                            DataTable dt3 = new DataTable();
                            decimal fee = Convert.ToDecimal(cboFee.SelectedItem.ToString());
                            dt3 = dsApp.GetDataBySearchFeeDESC(fee);
                            dgvSearch.DataSource = dt3;
                            dgvSearch.Refresh();
                        }

                    }
                    ColumnVisible();
                }
                else
                {
                    MessageBox.Show("Please choose one of the radio buttons and one of the combo box you want to search.");
                }
            
            
            
            
            
        }


        private void reset_S()
        {
            cboFee.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            cboEC.SelectedIndex = 0;
            rdoASC.Checked = false;
            rdoDESC.Checked = false;
            dgvSearch.DataSource = null;
        }



        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer_Home Ch = new Customer_Home();
            Ch.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Renting RR = new Renting();
            RR.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset_S();
        }
        
    }
}
