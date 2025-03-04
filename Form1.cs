using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022330150
{
    public partial class Calculator : Form
    {
        int p;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = int.Parse(output.Text);
            output.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int hasil = int.Parse(output.Text) + p;
            output.Text = hasil.ToString();
            output.Show();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            output.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            output.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            output.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            output.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            output.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            output.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            output.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            output.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            output.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            output.Text += "9";
        }
    }
}
