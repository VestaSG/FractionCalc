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
			int num1, num2, den1, den2;
			bool aNum1 = int.TryParse(textBox1.Text, out num1);
			bool aNum2 = int.TryParse(textBox4.Text, out num2);
			bool aDen1 = int.TryParse(textBox2.Text, out den1);
			bool aDen2 = int.TryParse(textBox3.Text, out den2);
			Fraction f1 = new Fraction(num1, den1);
			Fraction f2 = new Fraction(num2, den2);
			Fraction f3 = f1;
			if ("*" == comboBox1.Text)
			{
				f3 = f1.multiplication(f2);
			}
			if ("/" == comboBox1.Text)
			{
				f3 = f1.division(f2);
			}
			if ("+" == comboBox1.Text)
			{
				f3 = f1.addition(f2);
			}
			if ("-" == comboBox1.Text)
			{
				f3 = f1.subtraction(f2);
			}
			textBox6.Text = f3.getNumerator().ToString();
			textBox5.Text = f3.getDenomenator().ToString();
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			SimpleNums.getInstance();
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

		private void Form1_Shown(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 0;
		}
	}
}
