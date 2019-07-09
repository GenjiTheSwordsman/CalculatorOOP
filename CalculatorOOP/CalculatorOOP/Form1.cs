using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Value1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Value2_TextChanged(object sender, EventArgs e)
        {

        }
        private void ButtonPlus(object sender, EventArgs e)
        {
            double numberValueOne = Convert.ToDouble(Value1.Text);
            double numberValueTwo = Convert.ToDouble(Value2.Text);
            double numberOtvet = numberValueTwo + numberValueOne;
            textBox2.Text = numberOtvet.ToString();
        }
        private void ButtonMinus(object sender, EventArgs e)
        {
            double numberValueOne = Convert.ToDouble(Value1.Text);
            double numberValueTwo = Convert.ToDouble(Value2.Text);
            double numberOtvet = numberValueOne - numberValueTwo;
            textBox2.Text = numberOtvet.ToString();
        }

        private void ButtonMultiply(object sender, EventArgs e)
        {
            double numberValueOne = Convert.ToDouble(Value1.Text);
            double numberValueTwo = Convert.ToDouble(Value2.Text);
            double numberOtvet = numberValueTwo * numberValueOne;
            textBox2.Text = numberOtvet.ToString();
        }
        private void ButtonDivide(object sender, EventArgs e)
        {
            double numberValueOne = Convert.ToDouble(Value1.Text);
            double numberValueTwo = Convert.ToDouble(Value2.Text);
            double numberOtvet = numberValueOne / numberValueTwo;
            textBox2.Text = numberOtvet.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
