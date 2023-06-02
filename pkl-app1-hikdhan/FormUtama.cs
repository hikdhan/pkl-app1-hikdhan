using pkl_app1_hikdhan.space_invader;
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

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formkalkulator = new Formkallkulator();
            formkalkulator.Show();
            formkalkulator.MdiParent = this;
        }

        private void sequentialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formsequential = new Formsequential();
            formsequential.Show();
            formsequential.MdiParent = this;
        }

        private void percabanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formpercabangan = new Formpercbangan();
            formpercabangan.Show();
            formpercabangan.MdiParent = this;
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void procedurefunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formprocedurefunction = new FormProcedureFunction();
            formprocedurefunction.Show();
            formprocedurefunction.MdiParent = this;
        }

        private void arrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formArray = new FormArray();
            formArray.Show();
            formArray.MdiParent = this;
        }

        private void array2DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formArray2d = new FormArray2dimensi();
            formArray2d.Show();
            formArray2d.MdiParent = this;
        }

        private void animasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormAnimasi();
            form.Show();
            form.MdiParent = this;
        }

        private void spaceInvaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new background();
            form.Show();
            form.MdiParent = this;
        }
    }
}
