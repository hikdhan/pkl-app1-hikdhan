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
    public partial class FormString : Form
    {
        public FormString()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            label2.Text = $"HALO {nama}!";
        }

        private void FormString_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nama = textBox1.Text;
            var mulai = Convert.ToInt16(textBox2.Text);
            var jumlah = Convert.ToInt16(textBox3.Text);
            var hasil = nama.Substring(mulai, jumlah);
            label6.Text = $"HASILNYA ADALAH : {hasil}";
        }
    }
}
