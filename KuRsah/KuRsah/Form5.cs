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
    public partial class Form5 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maksim\Documents\Kyrcah.mdf;Integrated Security=True;Connect Timeout=30");
        public Form5()
        {
            InitializeComponent();
        }
        public void TextboxFilter()
        {
            Con.Open();
            string query = "select * from Customers1 where Name  = '" +textBox1.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        public void TextboxFilter1()
        {
            Con.Open();
            string query = "select * from Customers1 where Surname = '" + textBox1.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        public void TextboxFilter2()
        {
            Con.Open();
            string query = "select * from Customers1 where Tepephone  = '" + textBox1.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        public void TextboxFilter3()
        {
            Con.Open();
            string query = "select * from Customers1 where Age  = '" + textBox1.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextboxFilter1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextboxFilter2();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextboxFilter3();
        }
    }
}
