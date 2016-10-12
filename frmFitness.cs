using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    
    public partial class frmFitnessPlan : Form
    {
        frmMainMenu parent;

        public frmFitnessPlan(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();

        }

        private void btnMemberProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmNext = new frmProfile(this);

            this.Hide();
            frmNext.Show();

        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            frmPlan frmNext = new frmPlan(this);

            this.Hide();
            frmNext.Show();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            frmProgress frmNext = new frmProgress(this);

            this.Hide();
            frmNext.Show();

        }
    }
}
