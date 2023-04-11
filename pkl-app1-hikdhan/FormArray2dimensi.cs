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
    public partial class FormArray2dimensi : Form
    {
        private const int BOARD_SIZE = 8;
        private const int SQUARE_SIZE = 30;

        private Color terang = Color.FromArgb(255, 255, 255);
        private Color gelap = Color.FromArgb(0, 0, 0);
        private Color[,] kotakcatur = new Color[8, 8];
        private Bitmap kanvas = null;
        public FormArray2dimensi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (kanvas != null)
                e.Graphics.DrawImage(kanvas, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetWarnaKotak();
            DrawPapanCatur();
            panel1.Invalidate();
        }

        private void SetWarnaKotak()
        {
            for (int x = 0; x < BOARD_SIZE; x++)
            {
                for (int y = 0; y < BOARD_SIZE; y++) 
                {
                    Color warna = terang;
                    if (isganjil(x) && isganjil(y))
                        warna = terang;
                    if (isgenap(x) && isganjil(y))
                        warna = gelap;
                    if (isganjil(x) && isgenap(y))
                        warna = gelap;
                    if (isgenap(x) && isgenap(y))
                        warna = terang;
                    kotakcatur[x, y] = warna;
                }
            }
        }

        private void DrawPapanCatur()
        {
            kanvas = new Bitmap(panel1.Width, panel1.Height);
            using (var grafik = Graphics.FromImage(kanvas))
            {
                for (int x =0; x < BOARD_SIZE; x++)
                {
                    for (int y =0; y < BOARD_SIZE; y++)
                    {
                        Brush brush = new SolidBrush(kotakcatur[x, y]);
                        grafik.FillRectangle(brush, y * SQUARE_SIZE, x * SQUARE_SIZE, SQUARE_SIZE, SQUARE_SIZE);
                    }
                }
            }
        }

        private bool isganjil(int x)
        {
            if (x % 2 == 0)
                return false;
            else
                return true;
        }
        private bool isgenap(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
        public class Kotak
        {
            public Color Warna { get; set; }
        }

        private void PanelChessBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            if (kanvas != null)
                e.Graphics.DrawImage(kanvas, 0, 0);
        }
    }
}
