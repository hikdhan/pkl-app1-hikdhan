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
    public partial class FormProcedureFunction : Form
    {
        public FormProcedureFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = "didan";
            UcapSelamatPagi(nama);
        }

        private void UcapSelamatPagi(string name)
        {
            MessageBox.Show($"Good Morning {name}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "START")
            {
                button2.Text = "STOP";
                timer1.Enabled = true;
            }
            else
            {
                button2.Text = "START";
                timer1.Enabled = false;
                var hasil = apakahberhasil (progressBar1.Value);
                Tampilkanhasil(hasil);
            }
        }
        private int counter = -1;

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 20 || progressBar1.Value == 0)
                counter = -counter;
            progressBar1.Value += counter;
            label1.Text = progressBar1.Value.ToString();
        }

        private bool apakahberhasil (int score)
        {
            if (score == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Tampilkanhasil(bool sukses)
        {
            if (sukses)
            {
                label2.Text = "HORE MENANG!!!";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "YAHAHAHA KALAH!!!";
                label2.ForeColor = Color.Red;
            }
        }
    }
}
