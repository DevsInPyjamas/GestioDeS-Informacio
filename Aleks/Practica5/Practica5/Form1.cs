using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        private double inputNumberA;
        private double inputNumberB;
        private String operatorToExecute;
 

        public Form1()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e) {
            this.textBox1.Text = "";
            this.inputNumberA = 0;
            this.inputNumberB = 0;
            this.operatorToExecute = "";
        }

        private void delete_Click(object sender, EventArgs e) {
            if (this.textBox1.Text.Length != 0){
                this.textBox1.Text = this.textBox1.Text.Substring(0, this.textBox1.Text.Length - 1);
            }
        }

        private void button0_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(this.textBox1.Text)) {
                this.textBox1.AppendText("0");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText("9");
        }

        private void buttonSign_Click(object sender, EventArgs e) {
            String sign = this.textBox1.Text.Substring(0, 1);
            if(sign.Equals("-")) {
                this.textBox1.Text = this.textBox1.Text.Substring(1, this.textBox1.Text.Length - 1);
            } else {
                this.textBox1.Text = "-" + this.textBox1.Text;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e) {
            inputNumberB = Convert.ToDouble(textBox1.Text);
            switch (operatorToExecute) {
                case "+":
                    this.textBox1.Text = Convert.ToString(inputNumberA + inputNumberB);
                    break;
                case "-":
                    this.textBox1.Text = Convert.ToString(inputNumberA - inputNumberB);
                    break;
                case "*":
                    this.textBox1.Text = Convert.ToString(inputNumberA * inputNumberB);
                    break;
                case "/":
                    this.textBox1.Text = Convert.ToString(inputNumberA / inputNumberB);
                    break;
                case "":
                    this.textBox1.Text = inputNumberA.ToString();
                    break;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e) {
            inputNumberA = double.Parse(this.textBox1.Text);
            operatorToExecute = "+";
            this.textBox1.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e) {
            inputNumberA = double.Parse(this.textBox1.Text);
            operatorToExecute = "-";
            this.textBox1.Clear();
        }

        private void buttonMultiply_Click(object sender, EventArgs e) {
            inputNumberA = double.Parse(this.textBox1.Text);
            operatorToExecute = "*";
            this.textBox1.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e) {
            inputNumberA = double.Parse(this.textBox1.Text);
            operatorToExecute = "/";
            this.textBox1.Clear();
        }
    }
}
