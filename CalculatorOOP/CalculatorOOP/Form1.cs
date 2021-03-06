﻿using System;
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
        
        /// <summary>
        /// the function output on display result (take two arguments for input)
        /// and the function for create calculate for needed a button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClickForTwoArgumentsFunctions(object sender, EventArgs e)
        {
            try
            {
                double numberValueOne = Convert.ToDouble(Value1.Text);
                double numberValueTwo = Convert.ToDouble(Value2.Text);
                ITwoArgumentsCalculate calculator = TwoArgumentsFactory.CreateCalc(((Button)sender).Name);
                double result = calculator.TwoArgCalculate(numberValueOne, numberValueTwo);
                this.textBox2.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        /// <summary>
        /// the function take one argument for calculate
        /// this need for sqrt/pow/etc 
        /// a argument will be taken from the first input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClickForOneArgumentFunctions(object sender, EventArgs e)
        {
            try
            {
                double numberValueOne = Convert.ToDouble(Value1.Text);
                IOneArgumentCalculate calculator = OneArgumentFactory.CreateFac(((Button)sender).Name);
                double result = calculator.OneArgCalculate(numberValueOne);
                this.textBox2.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
