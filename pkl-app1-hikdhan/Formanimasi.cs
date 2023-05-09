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

        private int lastX = 0;
        private int lastY = 0;

        private int[] bodyX = new int[300];
        private int[] bodyY = new int[300];

        private string arah = "kanan";

        private int foodX = 21;
        private int foodY = 15;

        private int Score = 0;
        private int panjang = 0;

        int life;

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
                grafik.DrawImage(Properties.Resources.backgroun, 0,0, kanvas.Width,kanvas.Height);
                for (var i = 0; i < jm_kot; i++)
                {
                    for (var j = 0; j < jm_kot; j++)
                    {
                       // var brush = new SolidBrush(Color.DarkGreen);
                            //grafik.FillRectangle(brush, i * uk_kot, j * uk_kot, uk_kot, uk_kot);

                        //var pen = new Pen(Color.Azure);
                        //grafik.DrawRectangle(pen, i * uk_kot, j * uk_kot, uk_kot, uk_kot);
                    }
                }
            }
        }

        private void drawaktor()    
        {
            if (kanvas is null) return;
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brushBody = new SolidBrush(Color.GreenYellow);

                bodyX[0] = lastX;
                bodyY[0] = lastY;
                for (var i = panjang; i > 0; i--)
                {
                    if (i == 0) break;

                    bodyX[i] = bodyX[i - 1];
                    bodyY[i] = bodyY[i - 1];
                    grafik.DrawImage(pictureBox3.Image, bodyX[i] * uk_kot, bodyY[i] * uk_kot, uk_kot,uk_kot);
                }
                //var brushHead = new SolidBrush(Color.DarkRed);
                //grafik.FillRectangle(brushHead, actorX * uk_kot, actorY * uk_kot, uk_kot, uk_kot);
                //var brushHead = new SolidBrush(Color.DarkRed);
                grafik.DrawImage(pictureBox2.Image, actorX * uk_kot - 5, actorY * uk_kot - 5, 20, 20);
            }
        }

        private void drawmakanan()
        {
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.Red);
                grafik.DrawImage(pictureBox4.Image, foodX * uk_kot -5, foodY * uk_kot -5, 20, 20);
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

            lastX = actorX;
            lastY = actorY;
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

            label1.Text = $" score: {Score}";
            label2.Text = $"{arah}: {actorX},{actorY}";

            drawkotak();
            drawaktor();

            if (apakahaktormakanfood())
            {
                Randomfood();
                Score++;
                panjang++;
            }

            if (crash())
            {
                Life_index();
            }

            drawmakanan();
            Game_Update();
            head_snake();
            bodysnake();

            pictureBox1.Invalidate();
        }

        void head_snake()
        {
            if (arah == "atas")
            {
                pictureBox2.Image = Properties.Resources.headatas;
            }
            if (arah == "bawah")
            {
                pictureBox2.Image = Properties.Resources.pngwing_com;
            }
            if (arah == "kiri")
            {
                pictureBox2.Image = Properties.Resources.headkiri;
            }
            if (arah == "kanan")
            {
                pictureBox2.Image = Properties.Resources.headkanan;
            }
        }

        void bodysnake()
        {
            if (arah == "atas")
            {
                pictureBox3.Image = Properties.Resources.bodyatas;
            }
            if (arah == "bawah")
            {
                pictureBox3.Image = Properties.Resources.bodyatas;
            }
            if (arah == "kanan")
            {
                pictureBox3.Image = Properties.Resources.body;
            }
            if (arah == "kiri")
            {
                pictureBox3.Image = Properties.Resources.body;
            }
        }

        void Life_index()
        {
            if (life == 1)
            {
                life1.Image = Properties.Resources.life_white;
            }
            if (life == 2)
            {
                life2.Image = Properties.Resources.life_white;
            }
            if (life == 3)
            {
                life3.Image = Properties.Resources.life_white;
                gameover();
            }
        }

        private void RestartLive()
        {
            life = 0;
            life1.Image = Properties.Resources.life;
            life2.Image = Properties.Resources.life;
            life3.Image = Properties.Resources.life;

        }

        void Game_Update()
        {
            if (crash())
            {

                life += 1;
                Life_index();
            }
        }

        private bool crash()
        {
            for (var i = 0; i <=panjang; i++)
            {
                if (bodyX[i] != actorX) continue;
                if (bodyY[i] != actorY) continue;
                return true;
            }
            return false;
        }

        private void gameover()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.Red);
                grafik.DrawString("GAME OVER!!!", new Font("segoe print", 22), brush, new Point(50, 50));
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAnimasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            timer2.Enabled = true;
            actorX = 0;
            actorY = 0;
            arah = "kanan";
            panjang = 0;
            Score = 0;
            RestartLive();
            pictureBox1.Focus();
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
    }
}
