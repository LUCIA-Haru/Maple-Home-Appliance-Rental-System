using Microsoft.Reporting.WinForms;
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
    public partial class Reports : Form
    {
        HomeAppliance_DataSetTableAdapters.RentalTableAdapter dsRental = new HomeAppliance_DataSetTableAdapters.RentalTableAdapter();
        HomeAppliance_DataSetTableAdapters.RentalDetailTableAdapter dsRentalDetail = new HomeAppliance_DataSetTableAdapters.RentalDetailTableAdapter();
        DataTable dtRentalReport = new DataTable();
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HomeAppliance_DataSet.Rental' table. You can move, or remove it, as needed.
            this.RentalTableAdapter.Fill(this.HomeAppliance_DataSet.Rental);
            this.rgvReport.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            dtRentalReport = dsRental.GetData();
            rgvReport.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dtRentalReport);
            rgvReport.LocalReport.ReportPath = @"D:\L4DC\DDOCP\KHINE ZAR THWIN_P00198299_DDOCP_GA\Data Base\HomeAppliance_RentalSystem\HomeAppliance_RentalSystem\Voucher.rdlc";
            rgvReport.LocalReport.DataSources.Add(source);
            rgvReport.RefreshReport();
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_Home Ah = new Admin_Home();
            Ah.Show();
            this.Hide();
        }

    }
}
