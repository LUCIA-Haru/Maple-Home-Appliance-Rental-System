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
    public partial class Renting : Form
    {
        //Connecting to TableAdapter
        HomeAppliance_DataSetTableAdapters.RentalTableAdapter objHRent = new HomeAppliance_DataSetTableAdapters.RentalTableAdapter();
        HomeAppliance_DataSetTableAdapters.CustomerTableAdapter objHCustomer = new HomeAppliance_DataSetTableAdapters.CustomerTableAdapter();
        HomeAppliance_DataSetTableAdapters.RentalDetailTableAdapter objHRD = new HomeAppliance_DataSetTableAdapters.RentalDetailTableAdapter();
        HomeAppliance_DataSetTableAdapters.AppliancesTableAdapter objHAp = new HomeAppliance_DataSetTableAdapters.AppliancesTableAdapter();

        DataTable dtHAp = new DataTable();
        DataTable dtHCustomer = new DataTable();
        DataTable dtHR = new DataTable();
        DataRow dHr;

        public Renting()
        {
            InitializeComponent();


            //TO add new columns in dgv
            dtHR.Columns.Add("CustomerID", typeof(string));
            dtHR.Columns.Add("AppliancesID",typeof(string));
            dtHR.Columns.Add("AppliancesName", typeof(string));
            dtHR.Columns.Add("AppliancesQuantity", typeof(string));
            dtHR.Columns.Add("RentalFee", typeof(decimal));
            dtHR.Columns.Add("StartDate", typeof(DateTime));
            dtHR.Columns.Add("DueDate", typeof(DateTime));
            dtHR.Columns.Add("Duration", typeof(int));
            dtHR.Columns.Add("UnitAmount", typeof(string));
            dtHR.Columns.Add("TotalAmount", typeof(string));
            
            


            //CustomersDeatils
            //Show customer details
            lblCustomerID.Text = Customer_LoginForm.CustomerID;
            lblCustomerName.Text = Customer_LoginForm.CustomerName;
            lblCustomerNRC.Text = Customer_LoginForm.CustomerNRC;
            lblCustomerAddress.Text = Customer_LoginForm.CustomerAddress;
        }

        private void Renting_Load(object sender, EventArgs e)
        {
            SetAppliancesName();
            AutoID_R();
           
        }
        
        //Appliances Details
        //To Show the Appliances Name in combo box
        private void SetAppliancesName()
        {
            dtHAp = objHAp.GetDataByAvailable();

            cboApName.Items.Add("Choose Appliances Name.");
            for (int i = 0; i < dtHAp.Rows.Count; i++)
            {
                cboApName.Items.Add(dtHAp.Rows[i][1].ToString());
            }
            cboApName.SelectedIndex = 0;
        }
        //when the name was chosen, then its details were shown on accoding textboxes
        private void cboApName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();

            dt2 = objHAp.GetDataByAppliancesName(cboApName.SelectedItem.ToString());

            for (int x = 0; x < dt2.Rows.Count; x++)
            {
                txtApID.Text = dt2.Rows[x][0].ToString();
                txtApfee.Text = dt2.Rows[x][8].ToString();
                pbAPImage.Image = Image.FromFile(dt2.Rows[x][11].ToString());
                txtquantity.Text = dt2.Rows[x]["AppliancesQuantity"].ToString();
            }
        }

       //RentDetails
        private void AutoID_R()
        {
            DataTable dt3 = new DataTable();
            dt3 = objHRent.GetData();
            if (dt3.Rows.Count == 0)
            {
                txtRID.Text = "R_001";
            }
            else
            {
                int size = dt3.Rows.Count - 1;
                String oldID = dt3.Rows[size][0].ToString();

                int newID = Convert.ToInt32(oldID.Substring(2,3));
                if (newID >= 1 && newID < 9)
                {
                    txtRID.Text = "R_00" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    txtRID.Text = "R_0" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    txtRID.Text = "R_" + (newID + 1);
                }
            }
        }

        

        //ADD button
         private void btnADD_Click(object sender, EventArgs e)
        {
            
               

                if (cboApName.SelectedIndex == 0)
                {
                    MessageBox.Show("Please choose appliances' names.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else
                {
                    string searchValue = txtApID.Text;
                    bool isExist = false;

                    foreach (DataGridViewRow row in dgvRenting.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells["AppliancesID"].Value.ToString().Equals(searchValue))
                        {
                            isExist = true;
                            break;
                        }

                    }
                    
                    if (isExist)
                    {
                        MessageBox.Show("The AppliancesID is already exit in the Cart! ");
                    }
                    else
                    {
                        if (cboDuration.SelectedIndex > -1)
                        {
                            decimal UnitAmount = Convert.ToDecimal(txtApfee.Text) * Convert.ToInt32(cboDuration.SelectedItem.ToString());
                            txtUnitAmount.Text = Convert.ToString(UnitAmount);


                            dHr = dtHR.NewRow();
                            dHr["AppliancesID"] = txtApID.Text;
                            dHr["AppliancesName"] = cboApName.SelectedItem.ToString();
                            dHr["RentalFee"] = Convert.ToDecimal(txtApfee.Text);
                            dHr["AppliancesQuantity"] = txtquantity.Text;

                            dHr["StartDate"] = Convert.ToDateTime(dtpStart.Text);
                            dHr["DueDate"] = Convert.ToDateTime(dtpDue.Text);
                            dHr["Duration"] = cboDuration.SelectedItem.ToString();
                            dHr["UnitAmount"] = txtUnitAmount.Text;

                            dHr["CustomerID"] = lblCustomerID.Text;

                            
                            dtHR.Rows.Add(dHr);
                            dgvRenting.DataSource = dtHR;

                            
                            //Calculation totalQuantity

	                         int total = 0;
                             foreach (DataGridViewRow row in dgvRenting.Rows)
                            {
                                int quantity = Convert.ToInt32(row.Cells["AppliancesQuantity"].Value); // get the quantity value for the current row
                                total += quantity;
                            }
                             txtRTQ.Text = Convert.ToString(total);

                            //Calculation totalAmount
                            decimal TotalAmount = 0;
                            foreach (DataGridViewRow row in dgvRenting.Rows)
                            {
                                decimal subamount;
                                //subamount = Convert.ToDecimal(row.Cells["UnitAmount"].Value.ToString());
                                if (decimal.TryParse(row.Cells["UnitAmount"].Value.ToString(), out subamount))
                                {
                                    TotalAmount += subamount;
                                }


                            }

                            txtRTA.Text = TotalAmount.ToString();
                            dHr["TotalAmount"] = txtRTA.Text;
                        }
                        else
                        {
                            MessageBox.Show("Please choose duration! 😊");
                        }
                        
                    }
                    

                }
            
            
                
            
        }



        //Remove
         private void btnRemove_Click(object sender, EventArgs e)
         {
             if (dgvRenting.SelectedRows.Count > 0)
             {
                 int H_rowIndex = dgvRenting.SelectedRows[0].Index;
                 dgvRenting.Rows.RemoveAt(H_rowIndex);
                 //int H_rowCount = dgvRenting.Rows.Count;
                 //txtRTQ.Text = H_rowCount.ToString();
                 //Calculation totalQuantity

                 int total = 0;
                 foreach (DataGridViewRow row in dgvRenting.Rows)
                 {
                     int quantity = Convert.ToInt32(row.Cells["AppliancesQuantity"].Value); // get the quantity value for the current row
                     total += quantity;
                 }
                 txtRTQ.Text = Convert.ToString(total);
             }
             else
             {
                 MessageBox.Show("You can select a row to remove.");
             }
         }

        //Date changed
         private void cboDuration_SelectedIndexChanged(object sender, EventArgs e)
         {
             DateTime StartDate = dtpStart.Value;
             int Duration = Convert.ToInt32(cboDuration.SelectedItem.ToString());
             DateTime newDate = StartDate.AddMonths(Duration);
             dtpDue.Value = newDate;
             
           
         }

        //Save
         private void btnRent_Click(object sender, EventArgs e)
         {
             if (cboApName.SelectedIndex == 0)
             {
                 MessageBox.Show("Please choose appliances' names.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else if (cboDuration.SelectedIndex == -1)
             {
                 MessageBox.Show("Please choose appliances' duration.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else if (dgvRenting.DataSource == null)
             {
                 MessageBox.Show("Please click Add button.", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 string RentalID = txtRID.Text;

                 //// parsing from string to date
                 DateTime StartDate = DateTime.Parse(dtpStart.Text);
                 DateTime DueDate = DateTime.Parse(dtpDue.Text);
                 int duration = Convert.ToInt32(cboDuration.SelectedItem.ToString());
                 string CustomerID = lblCustomerID.Text;
                 int totalQuantity = int.Parse(txtRTQ.Text);
                 decimal unitAmount = decimal.Parse(txtUnitAmount.Text);
                 decimal totalAmount = decimal.Parse(txtRTA.Text);
                 String AppliancesStatus = "Unavailable";
                 string Status = "Rented";


                 objHRent.Insert(RentalID, StartDate, DueDate, duration, Status, totalQuantity, unitAmount, totalAmount, CustomerID);

                 for (int i = 0; i < dgvRenting.Rows.Count; i++)
                 {
                     string AppliancesID = dgvRenting.Rows[i].Cells["AppliancesID"].Value.ToString();

                     string RentalStatus = "Rented";
                     objHRD.Insert(AppliancesID, RentalID, duration, totalQuantity, unitAmount, totalAmount, RentalStatus);

                     //Update status
                     objHAp.UpdateStatus(AppliancesStatus, AppliancesID);
                 }


                 MessageBox.Show("TotalQuantity: " + totalQuantity + "\n" + "TotalAmount: " + totalAmount + "\n" + "Duration : " + duration + "Month" + "\n" + "You have rented these items successfully");
                 Reset_R();
                 AutoID_R();


                 Customer_Home CH = new Customer_Home();
                 CH.Show();
                 this.Hide();
             }
             
         }

        //Reset
         private void Reset_R()
         {
             cboApName.SelectedIndex = 0;
             txtApID.Clear();
             txtApfee.Clear();
             
             txtUnitAmount.Clear();
             txtRTA.Clear();
             txtRTQ.Clear();
             cboDuration.SelectedIndex = 0 ;
             dtpStart.Value = DateTime.Now;
             dtpDue.Value = DateTime.Now;
             pbAPImage.Image = null;

             
             //clear dgv
             dtHR.Clear();
             dgvRenting.DataSource = dtHR;
             dgvRenting.Refresh();
         }



        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer_Home CH = new Customer_Home();
            CH.Show();
            this.Hide();
        }

        private void btnRReset_Click(object sender, EventArgs e)
        {
            Reset_R();
        }

        
    }
}
