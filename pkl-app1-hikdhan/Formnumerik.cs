﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pkl_app1_hikdhan
{
    public partial class Formnumerik : Form
    {
        public Formnumerik()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formnumerik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data1 = Convert.ToInt64(textBox1.Text);
            var data2 = Convert.ToInt64(textBox2.Text);
            var hasil = data1 + data2;
            textBox3.Text = Convert.ToString(hasil);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data1 = Convert.ToInt64(textBox1.Text);
            var data2 = Convert.ToInt64(textBox2.Text);
            var hasil = data1 - data2;
            textBox3.Text = Convert.ToString(hasil);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var data1 = Convert.ToInt64(textBox1.Text);
            var data2 = Convert.ToInt64(textBox2.Text);
            var hasil = data1 * data2;
            textBox3.Text = Convert.ToString(hasil);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var data1 = Convert.ToDouble(textBox1.Text);
            var data2 = Convert.ToDouble(textBox2.Text);
            var hasil = data1 / data2;
            textBox3.Text = hasil.ToString("0.##");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
