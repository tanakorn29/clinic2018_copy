using System;
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
            clinic_insert cn = new clinic_insert();
            cn.Show();
        }

        private void clinic_main_v2_Load(object sender, EventArgs e)
        {
          //  clinic_login lgn = new clinic_login();
          //  lgn.Show();
        }

      


        private void B_login_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Show();
            this.toolStrip1.Show();
            this.panel1.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Show();
            this.menuStrip1.Hide();
            this.toolStrip1.Hide();
          //this.Close();
        }



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            clinic_search  cs = new clinic_search();
            cs.Show();
        }
    }
}
