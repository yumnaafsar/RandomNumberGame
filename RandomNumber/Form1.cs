using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            label3.Text = r.Next(1, 100).ToString();
            string rtext = label3.Text;
            label3.Visible = true;

            string ttext=textBox1.Text;

            if (rtext == ttext)
            {
                label6.Text = "You guessed it right :)";
                label6.Visible= true;
            }
            else
            {
                label6.Text = "Better luck next time :)";
                label6.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
