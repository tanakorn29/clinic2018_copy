﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic2018
{
    public partial class clinic_main_v2 : Form
    {
        public clinic_main_v2()
        {
            InitializeComponent();
        }

        private void scanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clinic_barcode newMDIchild = new clinic_barcode();
            newMDIchild.MdiParent = this;
            newMDIchild.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clinic_main_v2_Load(object sender, EventArgs e)
        {
            clinic_login lgn = new clinic_login();
            this.Show();
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clinic_identity_card sh1 = new clinic_identity_card();
            sh1.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clinic_identity_card sh1 = new clinic_identity_card();
            sh1.Show();
        }
    }
}
