using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuRsah
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int qt = 100;
            progressBar1.Maximum = qt;

            for (int i = qt; i > 0; i--)
            {
                progressBar1.Value++;
            }
            await Task.Delay(2000);
            timer1.Stop();
            this.Hide();
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
        }
    }
}
