﻿using System;
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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers frmNext = new frmMembers(this);

            this.Hide();
            frmNext.Show();

        }

        private void btnFitness_Click(object sender, EventArgs e)
        {
            frmFitnessPlan frmNext = new frmFitnessPlan(this);

            this.Hide();
            frmNext.Show();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

           frmAdmin frmNext = new frmAdmin(this);

            this.Hide();
            frmNext.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            picture.BorderStyle = BorderStyle.None;
        }
    }
}
