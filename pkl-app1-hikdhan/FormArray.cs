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
    public partial class FormArray : Form
    {
        public FormArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] bilganjil = new int[10];
            var index = 0;
            for(var bill = numericUpDown1.Value; bill <= numericUpDown2.Value; bill++)
            {
                if ( bill % 2 == 1)
                {
                    bilganjil[index] = (int)bill;
                    index++;
                    if (index >= 10)
                        break;
                }

            }
            textBox1.Text = string.Join(",", bilganjil);
        }
    }
}
