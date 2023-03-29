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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

        }

        private void stringNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormString = new FormString();
            FormString.Show();
            FormString.MdiParent = this;
        }

        private void numerikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formnumerik = new Formnumerik();
            Formnumerik.Show();
            Formnumerik.MdiParent = this;
        }

        private void hitungumurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formdate = new formdate();
            formdate.Show();
            formdate.MdiParent = this;
        }
    }
}
