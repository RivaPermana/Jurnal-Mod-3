using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3
{
    public partial class Form1 : Form
    {
        string tombol1, tombol2, tombol3, tombol4, tombol5, tombol6, tombol7, tombol8, tombol9, tombol0;
        int plus, equal;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tombol3 += "3";
            label1.Text += tombol3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tombol4 += "4";
            label1.Text += tombol4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tombol0 += "0";
            label1.Text += tombol0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tombol7 += "7";
            label1.Text += tombol7;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tombol9 += "9";
            label1.Text += tombol9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tombol8 += "8";
            label1.Text += tombol8;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tombol6 += "6";
            label1.Text += tombol6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tombol5 += "5";
            label1.Text += tombol5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            plus = Convert.ToInt32(label1.Text);
            label1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            equal = Convert.ToInt32(label1.Text);
            label1.Text = Convert.ToString(plus + plus);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tombol1 += "1";
            label1.Text += tombol1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tombol2 += "2";
            label1.Text += tombol2;
        }
    }
}
