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
    public partial class FormProsedureFunction : Form
    {
        public FormProsedureFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = "Didan";
            UcapSelamatPagi(nama);
        }

        private void UcapSelamatPagi(string nama)
        {
            MessageBox.Show($"Good Morning {nama}");
        } 
    }
}
