using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double readInput(TextBox input)
        {
            return Convert.ToDouble(input.Text);
        }

        double squareSum(double a, double b)
        {
            return a * a + b * b;
        }

        void writeOutput(TextBox output, double value) {
            output.Text = Convert.ToString(value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = readInput(textBox1);
            double b = readInput(textBox2);
            double res = squareSum(a, b);
            writeOutput(textBox3, res);
        }
    }
}
