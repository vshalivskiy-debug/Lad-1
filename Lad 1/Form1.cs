using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lad_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);

            double s = Math.Pow(y, Math.Pow(Math.Abs(x), 1.0 / 3.0))
    + Math.Pow(Math.Cos(y), 3)
    * (Math.Abs(x - y) * (1 + Math.Pow(Math.Sin(z), 2) / Math.Sqrt(x + y)))
    / (Math.Exp(Math.Abs(x - y)) + x / 2.0);

            label1.Text = "s = " + s.ToString("F6");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
