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

        double Vvod(TextBox input)
        {
            return Convert.ToDouble(input.Text);
        }

        double Sum_kv(double a, double b)
        {
            return a * a + b * b;
        }

        void Vyvod(TextBox output, double value) {
            output.Text = Convert.ToString(value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Vvod(textBox1);
            double b = Vvod(textBox2);
            double res = Sum_kv(a, b);
            Vyvod(textBox3, res);
        }
    }
}
