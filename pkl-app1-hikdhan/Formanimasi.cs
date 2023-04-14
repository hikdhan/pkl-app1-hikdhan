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
    public partial class FormAnimasi : Form
    {
        private Bitmap kanvas = null;
        private const int jm_kot = 40;
        private const int uk_kot = 8;

        private int actorX = 0;
        private int actorY = 0;

        private string arah = "kanan";

        private int foodX = 21;
        private int foodY = 15;

        private int Score = 0;
        public FormAnimasi()
        {
            InitializeComponent();
            drawkotak();
            drawaktor();
            drawmakanan();
        }

        private void drawkotak()
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                for (var i = 0; i < jm_kot; i++)
                {
                    for (var j = 0; j < jm_kot; j++)
                    {
                        var brush = new SolidBrush(Color.Azure);
                            grafik.FillRectangle(brush, i * uk_kot, j * uk_kot, uk_kot, uk_kot);

                        var pen = new Pen(Color.Azure);
                        grafik.DrawRectangle(pen, i * uk_kot, j * uk_kot, uk_kot, uk_kot);
                    }
                }
            }
        }

        private void drawaktor()
        {
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.Yellow);
                grafik.FillRectangle(brush, actorX * uk_kot, actorY * uk_kot, uk_kot, uk_kot);
            }
        }

        private void drawmakanan()
        {
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.Red);
                grafik.FillRectangle(brush, foodX * uk_kot, foodX * uk_kot, uk_kot, uk_kot);
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (kanvas == null)
                return;

            e.Graphics.DrawImage(kanvas, 10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (arah)
            {
                case "kanan":
                    actorX++;
                    break;
                case "kiri":
                    actorX--;
                    break;
                case "atas":
                    actorY--;
                    break;
                case "bawah":
                    actorY++;
                    break;
            }

            if (actorX > jm_kot - 1)
                actorX = 0;
            if (actorX < 0)
                actorX = jm_kot;
            if (actorY == jm_kot)
                actorY = 0;
            if (actorY < 0)
                actorY = jm_kot;

            label1.Text = $" Score kamu adalah: {Score}";

            drawkotak();
            drawaktor();

            if (apakahaktormakanfood())
            {
                Randomfood();
                Score++;
            }

            drawmakanan();

            pictureBox1.Invalidate();
        }

        private bool apakahaktormakanfood()
        {
            if (actorX == foodX && actorY == foodY)
                return true;
            return false;
        }

        private void Randomfood()
        {
            Random randomX = new Random();
            foodX = randomX.Next(0,jm_kot);

            Random randomY = new Random();
            foodY = randomY.Next(0, jm_kot);
            timer2.Stop();
            timer2.Start();
        }

        private void FormAnimasi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                arah = "kanan";
            if (e.KeyCode == Keys.Left)
                arah = "kiri";
            if (e.KeyCode == Keys.Up)
                arah = "atas";
            if (e.KeyCode == Keys.Down)
                arah = "bawah";
        }

        private void FormAnimasi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Randomfood();
            drawkotak();
            drawaktor();
            drawmakanan();
            pictureBox1.Invalidate();
        }
    }
}
