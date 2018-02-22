using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic2018
{
    public partial class clinic_search : Form
    {
        public clinic_search()
        {
            InitializeComponent();
        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }
        internal string Setlabel
        {
            set { label1.Text = "ค่าที่ได้รับ :" + " " + value; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //สร้างไว้ข้างนอก เพื่องานต่อการเรียกใช้ในส่วนอื่นๆ
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        //ในช่องค้นหา ใช้ Event ชื่อว่า TextChanged เมื่อช่องค้นหามีการเปลี่ยนแปลง ข้อความจะถูกเปลี่ยน
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select patient_name from patient where patient_idcard = '" + textBox2.Text + "'";
            cmd = new SqlCommand(query, conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
