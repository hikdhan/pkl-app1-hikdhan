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
    public partial class formdate : Form
    {
        public formdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tgllhr = dateTimePicker1.Value;
            var tglskg = DateTime.Now;

            var umur = tglskg.Date - tgllhr.Date;
            var umurhari = umur.TotalDays;
            label2.Text = $"Umur Kamu Adalah {umurhari:n0} hari";
        }
    }
}
