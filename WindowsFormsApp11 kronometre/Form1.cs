using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11_kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayac = Convert.ToInt32(label1.Text);
            sayac++;
            label1.Text = sayac.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text=("0");
        }
    }
}
