using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FractionCalc
{
	// Класс, отвечающий за работу с простыми числами и вычисления на их основе
	public class SimpleNums // singleton
	{
		private static SimpleNums instance;
		private List<int> SimpleNumsArray = new List<int>();

		public static SimpleNums getInstance(int MaxValue=100000)
		{
			if (instance == null)
			{
				instance = new SimpleNums(MaxValue);
			}
			return instance;
		}

		private SimpleNums(int MaxValue)
		{
			MaxValue = Math.Abs(MaxValue);
			for (int i = 2; i <= MaxValue; ++i)
			{
				for(int i2 = 2; i2 <= i; ++i2)
				{
					if(i2 == i)
					{
						SimpleNumsArray.Add(i);
						break;
					}
					else
					{
						if( (i%i2) == 0 )
						{
							break;
						}
					}
				}
			}
		}

		public List<int> SimpleNumsFor(int num)
		{
			num = Math.Abs(num);
			List<int> OutArray = new List<int>();
			int lsimples = SimpleNumsArray.Count();
			for (int i = 0; i < lsimples; ++i)
			{
				if(SimpleNumsArray[i] > num)
				{
					return OutArray;
				}
				if( (num%SimpleNumsArray[i]) == 0)
				{
					OutArray.Add(SimpleNumsArray[i]);
					num = num / SimpleNumsArray[i];
					i = -1;
				}				
			}
			return OutArray;
		}

		public string PrintArray(List<int> OutArray)
		{
			int larray = OutArray.Count();
			string OutString = "";
			for (int i = 0; i < larray; ++i)
			{
				OutString += OutArray[i].ToString() + ", ";
			}
			return OutString;
		}

		public string PrintSimpleNumsArray()
		{
			return PrintArray(SimpleNumsArray);
		}

		public string PrintSimpleNumsFor(int num)
		{
			return PrintArray(SimpleNumsFor(num));
		}

		// Наибольший общий делитель
		public int NOD(int first, int second)
		{
			first = Math.Abs(first);
			second = Math.Abs(second);
			List<int> OutArray = new List<int>();
			List<int> OutArray1 = SimpleNumsFor(first);
			List<int> OutArray2 = SimpleNumsFor(second);
			int l1 = OutArray1.Count();
			for(int i = 0; i < l1; ++i)
			{
				int l2 = OutArray2.Count();
				for(int i2 = 0; i2 < l2; ++i2)
				{
					if(OutArray1[i] == OutArray2[i2])
					{
						OutArray.Add(OutArray2[i2]);
						OutArray2.RemoveAt(i2);
//						OutArray1[i] = 0;
						break;
					}
				}
			}
			int outNOD = 1;
			int l = OutArray.Count();
			for (int i = 0; i < l; ++i)
			{
				outNOD *= OutArray[i];
			}
			return outNOD;
		}

		// Наименьшее общее кратное
		public int NOK(int first, int second)
		{
			first = Math.Abs(first);
			second = Math.Abs(second);
			return first * second / NOD(first, second);
		}
	}

	// Класс работы с дробями
	public class Fraction
	{
		private int Numerator;
		private int Denomenator;

		public int getNumerator()
		{
			return Numerator;
		}
		public int getDenomenator()
		{
			return Denomenator;
		}

		// метод упрощения дроби
		protected void simplify()
		{
			int FractionNOD = SimpleNums.getInstance().NOD(Numerator, Denomenator);
			Numerator = Numerator / FractionNOD;
			Denomenator = Denomenator / FractionNOD;
		}

		public Fraction(int Numerator, int Denomenator)
		{
			this.Numerator = Numerator;
			this.Denomenator = Denomenator;
			simplify();
		}

		// addition, subtraction, multiplication, division
		// возвращают новый объект дроби
		public Fraction addition(Fraction FractionObj)
		{
			int den = SimpleNums.getInstance().NOK(Denomenator, FractionObj.getDenomenator());
			int num = Numerator * (den / Denomenator);
			int num2 = FractionObj.getNumerator() * (den / FractionObj.getDenomenator());
			return new Fraction((num + num2), den);
		}
		public Fraction subtraction(Fraction FractionObj)
		{
			int den = SimpleNums.getInstance().NOK(Denomenator, FractionObj.getDenomenator());
			int num = Numerator * (den / Denomenator);
			int num2 = FractionObj.getNumerator() * (den / FractionObj.getDenomenator());
			return new Fraction((num - num2), den);
		}
		public Fraction multiplication(Fraction FractionObj)
		{
			return new Fraction(Numerator * FractionObj.getNumerator(), Denomenator * FractionObj.getDenomenator());
		}
		public Fraction division(Fraction FractionObj)
		{
			return new Fraction(Numerator * FractionObj.getDenomenator(), Denomenator * FractionObj.getNumerator());
		}
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
