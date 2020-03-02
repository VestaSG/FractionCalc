using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FractionCalc
{
	public class Fraction
	{
		private int Numerator;
		private int Denomenator;

		public Fraction(int Numerator, int Denomenator)
		{
			this.Numerator = Numerator;
			this.Denomenator = Denomenator;
		}
		// addition, subtraction, multiplication, division
	}

	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
