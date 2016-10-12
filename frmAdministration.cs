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
    public partial class frmAdmin : Form
    {
        frmMainMenu parent;

        public frmAdmin(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();

        }

    

        private void btnFees_Click(object sender, EventArgs e)
        {
            frmFees frmNext = new frmFees(this);

            this.Hide();
            frmNext.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            frmAnalysis frmNext = new frmAnalysis(this);

            this.Hide();
            frmNext.Show();
        }
    }
}
