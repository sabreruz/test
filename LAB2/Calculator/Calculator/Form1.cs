using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		double result, num1 = 0, num2 = 0;
        private bool isNewEntry = true;
        private bool isEqualPressed = false;
        String op;
		public Form1()
		{
			InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100); // 視窗啟動位置設定為 (100, 100)
        }

		public void button_show()
		{
			addition.Enabled = true;
			subtraction.Enabled = true;
			multiplication.Enabled = true;
			division.Enabled = true;
		}

        private void addition_Click(object sender, EventArgs e)
        {
            addition.Enabled = true;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                if (isEqualPressed)
                {
                    // 如果剛按過 "=", 讓 firstNumber 保持結果，允許繼續運算
                    isEqualPressed = false;
                }
                else if (!string.IsNullOrEmpty(op) && !isNewEntry)
                {
                    num2 = currentNumber;
                    PerformCalculation(); 
                }
                else
                {
                    num1 = currentNumber;
                }
            }
            op = "+";
            isNewEntry = true;
            isEqualPressed = false;
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }

            textBox1.Text += "0";
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "1";
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "2";
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "3";
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "4";
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "5";
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "6";
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "7";
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "8";
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "9";
        }
     

		private void button14_Click(object sender, EventArgs e)
		{
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            textBox1.Text += "0";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            subtraction.Enabled = true;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                if (isNewEntry || isEqualPressed)
                {
                    textBox1.Clear();
                    isEqualPressed = false;
                    isNewEntry = false;
                }
                textBox1.Text += "-";
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                if (isEqualPressed)
                {
                    // 如果剛按過 "=", 讓 firstNumber 保持結果，允許繼續運算
                    isEqualPressed = false;
                }
                else if (!string.IsNullOrEmpty(op) && !isNewEntry)
                {
                    num2 = currentNumber;
                    PerformCalculation();
                }
                else
                {
                    num1 = currentNumber;
                }
                op = "-";
                isNewEntry = true;
                isEqualPressed = false;
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            multiplication.Enabled = true;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                if (isEqualPressed)
                {
                    // 如果剛按過 "=", 讓 firstNumber 保持結果，允許繼續運算
                    isEqualPressed = false;
                }
                else if (!string.IsNullOrEmpty(op) && !isNewEntry)
                {
                    num2 = currentNumber;
                    PerformCalculation();
                }
                else
                {
                    num1 = currentNumber;
                }
            }
            op = "*";
            isNewEntry = true;
            isEqualPressed = false;
        }

        private void division_Click(object sender, EventArgs e)
        {
            division.Enabled = true;
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                if (isEqualPressed)
                {
                    // 如果剛按過 "=", 讓 firstNumber 保持結果，允許繼續運算
                    isEqualPressed = false;
                }
                else if (!string.IsNullOrEmpty(op) && !isNewEntry)
                {
                    num2 = currentNumber;
                    PerformCalculation();
                }
                else
                {
                    num1 = currentNumber;
                }
            }
            op = "/";
            isNewEntry = true;
            isEqualPressed = false;
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            if (isNewEntry || isEqualPressed)
            {
                textBox1.Clear();
                isEqualPressed = false;
                isNewEntry = false;
            }
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!isEqualPressed) // 第一次按 "=" 時，記住 secondNumber
                {
                    num2 = double.Parse(textBox1.Text);
                    PerformCalculation();
                }
                else 
                {
                    PerformCalculation();
                }

                //PerformCalculation();
                isEqualPressed = true; // 允許連續 "=" 計算
            }
        }

        private void PerformCalculation()
        {
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        textBox1.Text = "錯誤";
                        button_show();
                        num1 = 0;
                        num2 = 0;
                        op = "";
                        isNewEntry = true;
                        isEqualPressed = false;
                        return;
                    }
                    break;
            }
            textBox1.Text = Convert.ToString(result);
            num1 = result;
            return;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            button_show();
            num1 = 0;
            num2 = 0;
            textBox1.Text = "";
            op = "";
            isNewEntry = true;
            isEqualPressed = false;
        }
	}
}
