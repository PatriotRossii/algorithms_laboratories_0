using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public class Class1
    {
        public static double readInput(TextBox input)
        {
            return Convert.ToDouble(input.Text);
        }

        public static double squareSum(double a, double b)
        {
            return a * a + b * b;
        }

        public static void writeOutput(TextBox output, double value)
        {
            output.Text = Convert.ToString(value);
        }

    }
}
