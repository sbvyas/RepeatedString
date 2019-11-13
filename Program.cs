using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLeftRotation
{
	class Program
	{
		static int[] rotLeft(int[] a, int d)
		{

			int[] aRotLeft = new int[a.Length];
			int aPosition = a.Length;
			for (int i = 0; i < a.Length; i++)
			{
				aRotLeft[(i + aPosition - d) % aPosition] = a[i]; 
			}
			return aRotLeft;
		}

		static void Main(string[] args)
		{
			TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

			string[] nd = Console.ReadLine().Split(' ');

			int n = Convert.ToInt32(nd[0]);

			int d = Convert.ToInt32(nd[1]);

			int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
			;
			int[] result = rotLeft(a, d);

			textWriter.WriteLine(string.Join(" ", result));

			textWriter.Flush();
			textWriter.Close();
		}
	}
}
