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
        
        private void ButtonClick(object sender, EventArgs e)
        {
            double numberValueOne = Convert.ToDouble(Value1.Text);
            double numberValueTwo = Convert.ToDouble(Value2.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalc(((Button)sender).Name);
            double result = calculator.Calculate(numberValueOne, numberValueTwo);
            this.textBox2.Text = result.ToString();
        }

        private void ButtonClickForSqrtAndPow(object sender, EventArgs e)
        {
            double numberValueOne = Convert.ToDouble(Value1.Text);
            INterfaceForPowAndSQRT calculator = FactoryForSqrtAndPow.CreateFac(((Button)sender).Name);
            double result = calculator.Calculte(numberValueOne);
            this.textBox2.Text = result.ToString();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
