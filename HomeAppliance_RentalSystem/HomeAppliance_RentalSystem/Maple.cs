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
    public partial class Maple : Form
    {
        public Maple()
        {
            InitializeComponent();
        }
        int second = 0;
        private void timerMaple_Tick(object sender, EventArgs e)
        {
            second++;
           
            pnlProgress.Left += 2;
            if (pnlProgress.Left > 280)
            {
                pnlProgress.Left = 0;
            }
            if (pnlProgress.Left + pnlProgress.Width > pnlBar.Width+3)
            {
                pnlProgress.Left = 0;
            }
            if (second == 135)
            {
                Main_LogInForm MLF = new Main_LogInForm();
                timerMaple.Stop();
                MLF.Show();
                this.Hide();
            }
        }

        private void Maple_Load(object sender, EventArgs e)
        {
            timerMaple.Start();
        }
    }
}
