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
    public partial class Form2 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maksim\Documents\Kyrcah.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }
        public void populateGrid()
        {
            Con.Open();
            string query = "select * from Customers1";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 F4 = new Form5();
            F4.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {   
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 F4 = new Form6();
            F4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F4 = new Form1();
            F4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 F4 = new Form7();
            F4.Show();
        }
    }
}
