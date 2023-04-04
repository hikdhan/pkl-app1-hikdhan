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
    public partial class Formpercbangan : Form
    {
        private int waktu = 0;
        private int score = 0;
        private int[] kodewarna = { 0, 1, 2, 3 };
        private string[] namawarna = { "merah", "kuning", "hijau", "biru" };
        private int kodewarnaskg = 1;
        public Formpercbangan()
        {
            InitializeComponent();
        }

        private void acakwarna()
        {
            Random random = new Random();
            int randomvalue = random.Next(0, 4);
            label1.Text = namawarna[randomvalue];
            label2.Text = score.ToString();
            kodewarnaskg = randomvalue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acakwarna();
            waktu = 30;
            timer1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waktu--;
            label3.Text = waktu.ToString();
            if (waktu <= 0)
            {
                label3.Text = "game over";
                timer1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kodewarnaskg == 0)
            {
                score++;
                acakwarna();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kodewarnaskg == 1)
            {
                score++;
                acakwarna();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kodewarnaskg == 2)
            {
                score++;
                acakwarna();
                 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (kodewarnaskg == 3)
            {
                score++;
                acakwarna();
            }
        }

        private void Formpercbangan_Load(object sender, EventArgs e)
        {

        }
    }
}