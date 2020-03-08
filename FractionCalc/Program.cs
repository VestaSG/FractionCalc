using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FractionCalc
{
	public class SimpleNums
	{
		private List<int> SimpleNumsArray = new List<int>();

		public SimpleNums(int MaxValue)
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

		public int NOK(int first, int second)
		{
			first = Math.Abs(first);
			second = Math.Abs(second);
			return first * second / NOD(first, second);
		}
	}

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
