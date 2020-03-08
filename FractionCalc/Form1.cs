using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FractionCalc
{
	public partial class Form1 : Form
	{
		private SimpleNums SimpleNumsObj;

		public Form1()
		{
			InitializeComponent();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8)
			{
				e.Handled = true;
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8)
			{
				e.Handled = true;
			}
		}

		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8)
			{
				e.Handled = true;
			}
		}

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if (!Char.IsDigit(number) && number != 8)
			{
				e.Handled = true;
			}
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			int num1, num2, den1, den2, num, den;
			bool aNum1 = int.TryParse(textBox1.Text, out num1);
			bool aNum2 = int.TryParse(textBox4.Text, out num2);
			bool aDen1 = int.TryParse(textBox2.Text, out den1);
			bool aDen2 = int.TryParse(textBox3.Text, out den2);
			num = 0;
			den = 0;
			if ("*" == comboBox1.Text)
			{
				num = (num1 * num2);
				den = (den1 * den2);
			}
			if ("/" == comboBox1.Text)
			{
				num = (num1 * den2);
				den = (den1 * num2);
			}
			if ("+" == comboBox1.Text)
			{
				den = SimpleNumsObj.NOK(den2, den1);
				num1 = num1 * (den / den1);
				num2 = num2 * (den / den2);
				num = (num1 + num2);
			}
			if ("-" == comboBox1.Text)
			{
				den = SimpleNumsObj.NOK(den2, den1);
				num1 = num1 * (den / den1);
				num2 = num2 * (den / den2);
				num = (num1 - num2);
			}
			int resultNOD = SimpleNumsObj.NOD(num, den);
			num = num / resultNOD;
			den = den / resultNOD;
			textBox6.Text = num.ToString();
			textBox5.Text = den.ToString();
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			SimpleNumsObj = new SimpleNums(100000);
		}

		private void replaseButton_Click(object sender, EventArgs e)
		{
			string temp1 = textBox1.Text;
			string temp2 = textBox2.Text;
			textBox1.Text = textBox4.Text;
			textBox2.Text = textBox3.Text;
			textBox4.Text = temp1;
			textBox3.Text = temp2;
		}
	}
}
