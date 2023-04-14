using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace pkl_app1_hikdhan
{
    public partial class Formgraphics : Form
    {
        private Bitmap kanvas = null;
        public Formgraphics()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var Brush = new LinearGradientBrush(new Point(0,0), new Point(450,450), Color.AliceBlue, Color.DarkBlue);
                var polygon = new Point[]
                {
                    new Point(100,10),
                    new Point(50,150),
                    new Point (150,150),
                    new Point (200,10)
                };
                grafik.FillPolygon(Brush, polygon);
            }
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var pen = new Pen(Color.Aqua);
                grafik.DrawRectangle(pen, 10, 10, 100, 100);
            }
            pictureBox1.Invalidate();
        }

        //private void pictureBox1_Paint(object sender, EventArgs e)
        //{
        //     if (kanvas == null)
        //        return;
        //     e.Graphics.DrawImage(kanvas, 0, 0);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var brush = new SolidBrush(Color.Aquamarine);
                grafik.FillRectangle(brush, 10, 10, 100, 100);
            }
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                var pen = new Pen(Color.Aqua);
                grafik.DrawEllipse(pen, 10, 10, 100, 100);
            }
            pictureBox1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                
                var brush = new HatchBrush(HatchStyle.ZigZag, Color.Aquamarine);
                grafik.FillEllipse(brush, 10, 10, 100, 100);
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (kanvas == null)
                return;
            e.Graphics.DrawImage(kanvas, 0, 0);
        }
    }
}
