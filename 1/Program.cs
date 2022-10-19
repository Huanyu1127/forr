using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int minValue = 2;
			int maxValue = 50;
			int result=-1;

			for (int input = minValue; input <= maxValue; input++)
			{
				for (int i = 2; i <= Math.Ceiling(Math.Sqrt(input)); i++) //2~50
				{
					 result = 1; //
					if (input % i == 0)
					{
						result = 0;
						break;
					}
					
					//有一個變數記錄她是不是值數
				}
				if (result == 1)
				{
					Console.WriteLine(input);
				}
			}
		}
	}
}
