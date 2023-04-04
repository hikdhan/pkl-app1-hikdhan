using System;
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
    public partial class Formkallkulator : Form
    {
        private double angkaTampilan = 0;
        private double angkaMemory = 0;
        private string operasi = "";
        public Formkallkulator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
           angkaTampilan =  Convert.ToDouble(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operasi == "tambah")
                angkaMemory = angkaTampilan + angkaMemory;

            if (operasi == "kurang")
                angkaMemory = angkaMemory - angkaTampilan;

            if (operasi == "kali")
                angkaMemory = angkaTampilan * angkaMemory;

            if (operasi == "bagi")
                angkaMemory = angkaTampilan / angkaMemory;

            textBox1.Text = angkaMemory.ToString("0.##");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            angkaTampilan = Convert.ToDouble(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            angkaMemory = angkaTampilan;
            angkaTampilan = 0;
            operasi = "kurang";
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            angkaMemory = angkaTampilan;
            angkaTampilan = 0;
            operasi = "tambah";
            textBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            angkaMemory = angkaTampilan;
            angkaTampilan = 0;
            operasi = "kali";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            angkaMemory = angkaTampilan;
            angkaTampilan = 0;
            operasi = "bagi";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var angka = textBox1.Text;
            var angkaPotong = angka.Substring(0, angka.Length - 1);
            textBox1.Text = angkaPotong;
        }
    }
}
