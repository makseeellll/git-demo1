using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KuRsah
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maksim\Documents\Kyrcah.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            int  i = 0;
            SqlCommand cmd = new SqlCommand(" select * from MyUser where Name = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", Con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dac = new SqlDataAdapter(cmd);
            dac.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i==0)
            {
                MessageBox.Show("Не верный логин или пароль");
            }
            else
            {
               
                this.Hide();
                Form4 F2 = new Form4();
                F2.Show();
            }
;
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
