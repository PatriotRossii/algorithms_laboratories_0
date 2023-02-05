using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using library;

namespace main_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Class1.readInput(textBox1);
            double b = Class1.readInput(textBox2);
            double res = Class1.squareSum(a, b);
            Class1.writeOutput(textBox3, res);
        }
    }
}
