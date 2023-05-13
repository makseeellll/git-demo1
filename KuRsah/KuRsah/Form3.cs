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
    public partial class Form3 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maksim\Documents\Kyrcah.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(" insert into Customers1 values ( '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Добавлено");
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
