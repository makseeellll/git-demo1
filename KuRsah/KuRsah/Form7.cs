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
    public partial class Form7 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maksim\Documents\Kyrcah.mdf;Integrated Security=True;Connect Timeout=30");
        public Form7()
        {
            InitializeComponent();
        }
        public void populateGrid()
        {
            Con.Open();
            string query = "select * from ProductList";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        public void populateGrid1()
        {
            Con.Open();
            string query = "select * from TypeOfTraining";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F4 = new Form2();
            F4.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            populateGrid1();
            populateGrid();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
