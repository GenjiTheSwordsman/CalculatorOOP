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
            double numberValueOne;
            double numberValueTwo;
            double numberOtvet;
            switch (((Button)sender).Name)
            {
                case "button1":
                    numberValueOne = Convert.ToDouble(Value1.Text);
                    numberValueTwo = Convert.ToDouble(Value2.Text);
                    numberOtvet = numberValueTwo + numberValueOne;
                    textBox2.Text = numberOtvet.ToString();
                    break;
                case "button2":
                    numberValueOne = Convert.ToDouble(Value1.Text);
                    numberValueTwo = Convert.ToDouble(Value2.Text);
                    numberOtvet = numberValueOne - numberValueTwo;
                    textBox2.Text = numberOtvet.ToString();
                    break;
                case "button3":
                    numberValueOne = Convert.ToDouble(Value1.Text);
                    numberValueTwo = Convert.ToDouble(Value2.Text);
                    numberOtvet = numberValueTwo * numberValueOne;
                    textBox2.Text = numberOtvet.ToString();
                    break;
                case "button4":
                    numberValueOne = Convert.ToDouble(Value1.Text);
                    numberValueTwo = Convert.ToDouble(Value2.Text);
                    numberOtvet = numberOtvet = numberValueOne / numberValueTwo;
                    textBox2.Text = numberOtvet.ToString();
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
