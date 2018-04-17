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
                GlobalVariables.a++;
                MessageBox.Show("OK", "Result");
            }
            else if (dr == DialogResult.Cancel)
            {
                GlobalVariables.a = 0;
                MessageBox.Show("Cancel", "Result");
            }
            if (GlobalVariables.a == 2)
            {
                MessageBox.Show(GlobalVariables.a.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Form2 form2 = new Form2();
            form2.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "a value : " + GlobalVariables.a.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
