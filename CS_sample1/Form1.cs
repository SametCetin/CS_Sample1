using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_sample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure", "Attention", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                MessageBox.Show("OK", "Result");
            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel", "Result");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
