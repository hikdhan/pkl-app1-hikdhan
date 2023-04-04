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
    public partial class Formsequential : Form
    {
        public Formsequential()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Budi membeli 7 appel dan 5 mangga dan membutuhkan 1 kantong plastik
            //1 buah appel=1500
            //1 buah mangga=1300
            //kantung plastik=200
            //uang yang di bawa budi 50000

            var hargaapple = 1500;
            var jumapple = 7;
            var hargamangga = 1300;
            var jummangga = 5;
            var kresek = 200;
            var uang = 50000;

            var totalapple = hargaapple * jumapple;
            var totalmangga = hargamangga * jummangga;
            var totalbelanja = totalapple + totalmangga + kresek;
            var kembalian = uang - totalbelanja;

            textBox1.Text = $"kembalian : (uang= Rp{uang}) - (total belanja= Rp{totalbelanja})  kembalian = Rp{kembalian}. ";
        }
    }
}
