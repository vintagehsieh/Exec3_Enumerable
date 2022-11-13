using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable_Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//利用Enumerable.Range()建立一個序列、值在[1, 10]
			//請利用回全列出每一個項目值，確認無誤
			IEnumerable<int> numbers1 = Enumerable.Range(1, 10);

			foreach (var number in numbers1)
			{
				Console.WriteLine(number);
			}

			Console.WriteLine();


			//利用Enumerable.Range()建立一個序列、值在[10, 15]
			//請利用回全列出每一個項目值，確認無誤
			IEnumerable<int> numbers2 = Enumerable.Range(10, 6);

			foreach (var number in numbers2)
			{
				Console.WriteLine(number);
			}
		}
	}
}
