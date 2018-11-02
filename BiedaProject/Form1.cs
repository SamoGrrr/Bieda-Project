using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiedaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Sanepik > Kononowitz";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "CALE TE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "I told you so.";
        }
    }
}
