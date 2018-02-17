using System;
using System.Windows.Forms;
//-----------------------------------
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Linq;
using System.Drawing;

namespace Clinic2018
{
    public partial class clinic_insert : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VAM0JO2\SQLEXPRESS; Initial Catalog=Clinic2018; User ID=tanakorn29; Password=111111");
        
        public clinic_insert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox5_Click(object sender, EventArgs e)
        {
        /*    conn.Open(); //ทดสอบ
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select province_name from provinces";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox5.Items.Add(dr["province_name"].ToString());
            }

            conn.Close();
            */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void patient_id_TextChanged(object sender, KeyPressEventArgs e)
        {
            patient_id.MaxLength = 13;
            if (patient_id.Text ==  )
            {
                label6.ForeColor = Color.Green;
                label6.Text = "ครบ 13 หลัก";
            }
            else
            {
                label6.ForeColor = Color.Red;
                label6.Text = "ไม่ครบ 13 หลัก";
            }
        }*/

        private bool IsNumeric(string text)
        {
            throw new NotImplementedException();
        }

        //บันทึกข้อมูลลง Database
        private void button1_Click_1(object sender, EventArgs e)
        {
            string insertquery = "insert into patient(patient_id) values('" + patient_id.Text + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insertquery, conn);
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //แสดงข้อความแทน
                    label6.ForeColor = Color.Green;
                    label6.Text = "ครบ 13 หลัก";

                    //แสดงป็อปอัพข้อความแทน
                    //MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            conn.Close();
        }

        /*public void Regexp(string re, TextBox tb, PictureBox pc, Label lbel, string s)
        {
            //patient_id.MaxLength = 13;
            Regex reger = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.valid;
                lbel.ForeColor = Color.Red;
                lbel.Text = s + " InValid";
            }
            else
            {
                pc.Image = Properties.Resources.valid;
                lbel.ForeColor = Color.Green;
                lbel.Text = s + " Valid";
            }*/

    }
    }
