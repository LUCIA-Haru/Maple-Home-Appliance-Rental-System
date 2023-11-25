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
    public partial class Searching_Appliances : Form
    {
        HomeAppliance_DataSetTableAdapters.RentalTableAdapter dsRental = new HomeAppliance_DataSetTableAdapters.RentalTableAdapter();
        HomeAppliance_DataSetTableAdapters.RentalDetailTableAdapter dsRT = new HomeAppliance_DataSetTableAdapters.RentalDetailTableAdapter();
        HomeAppliance_DataSetTableAdapters.CustomerTableAdapter dsC = new HomeAppliance_DataSetTableAdapters.CustomerTableAdapter();

        DataTable dtRent = new DataTable();
        DataTable dt= new DataTable();
        DataTable dt2 = new DataTable();

        public Searching_Appliances()
        {
            InitializeComponent();
            
            
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rdoDate.Checked = false;
            rdoID.Checked = false;
            cboRentalID.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;

            dtRent = dsRT.GetDataBySHowALL();
            dgvSearch.DataSource = dtRent;
            dgvSearch.Refresh();
            dgvSearch.Columns["UnitAmount"].Visible = false;
        }

        //Search by RentalID
        private void SetRentalID()
        {
            //dtRent = dsRental.GetDataBy_SearchbyID(cboRentalID.SelectedItem.ToString());
            dt2 = dsRental.GetData();
            cboRentalID.Items.Add("Choose Rental ID");
            for (int j = 0; j < dt2.Rows.Count; j++)
            {
                cboRentalID.Items.Add(dt2.Rows[j][0].ToString());
            }
            cboRentalID.SelectedIndex = 0;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //rdoValidation
            if (rdoID.Checked)
            {
                dt2 = dsRT.GetDataByID(cboRentalID.SelectedItem.ToString());
                dgvSearch.DataSource = dt2;
                dgvSearch.Refresh();

                dgvSearch.Columns["UnitAmount"].Visible = false;
            }

            else if (rdoDate.Checked)
            {
                dt = dsRT.GetDataByDate(dtpFrom.Text, dtpTo.Text);
                dgvSearch.DataSource = dt;
                dgvSearch.Refresh();

                dgvSearch.Columns["UnitAmount"].Visible = false;
            }
            else
            {
                MessageBox.Show("Please click  radio button.");
            }

            
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Home AH = new Admin_Home();
            AH.Show();
            this.Hide();
        }

        private void Searching_Appliances_Load(object sender, EventArgs e)
        {
            SetRentalID();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoDate.Checked = false;
            rdoID.Checked = false;
            cboRentalID.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;

            dgvSearch.DataSource = null;
            dgvSearch.Refresh();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reports rr = new Reports();
            rr.Show();
            this.Hide();
        }
    }
}
