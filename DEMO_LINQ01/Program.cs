using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_LINQ01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// DEMO01();
			// DEMO02();
			// DEMO03();
			// DEMO04();
			// DEMO05();
			// DEMO05B();
			DEMO06();
		}
		private static void DEMO01()
		{
			// first array 裡, > 500 的第一筆
			int[] items = new int[] { 1, 50, 60, 13, 435, 54, 11 };
			int firstValue = items.First(x => x > 500); // 若找不到符合的值, 就丟出例外
			int firstValue2 = items.FirstOrDefault(x => x > 500); // 若找不到符合的值, 就丟出預設值

			Console.WriteLine(firstValue);
			Console.WriteLine(firstValue2);
		}
		private static void DEMO02()
		{
			// first array 裡, 是否有 > 0 的資料
			int[] items = new int[] { 1, 50, 60, 13, 435, 54, 11 };
			bool result = items.All(x => x > 0);
			Console.WriteLine(result);
		}
		private static void DEMO03()
		{
			// first array 裡, 是否至少有一筆 < 0 的資料
			int[] items = new int[] { 1, 50, 60, 13, 435, 54, 11 };
			bool result = items.Any(x => x < 0);
			Console.WriteLine(result);
		}
		/// <summary>
		/// 聚合函數, Sum, Count, Average, Max, Min
		/// </summary>
		private static void DEMO04()
		{
			// 加總
			int[] items = new int[] { 1, 50, 60, 13, 435, 54, 11 ,5 };
			Console.WriteLine("加總: " + items.Sum());
			// 小於 10 的加總
			Console.WriteLine("小於 10 的總和: " + items.Where(x => x < 10).Sum());
			// 總筆數
			Console.WriteLine("總筆數: " + items.Count());
			Console.WriteLine("小於 10 總筆數: " + items.Count(x => x < 10));
			Console.WriteLine("小於 10 總筆數#2: " + items.Where(x => x < 10).Count());
			Console.WriteLine("平均數: " + items.Average());
			Console.WriteLine("前三筆的平均數: " + items.Take(3).Average());
			Console.WriteLine("前三筆的平均數, 顯示到小數點兩位: " + items.Take(3).Average().ToString("f2"));
			Console.WriteLine("最大值: " + items.Max());
			Console.WriteLine("最小值: " + items.Min());

		}
		private static void DEMO05()
		{
			// 計算累加
			string[] items = new string[] { "A", "B", "C" };
			string result = items.Aggregate((acc, next) => acc + "," + next);
			Console.WriteLine(result);
		}
		private static void DEMO05B()
		{
			// 計算累加
			int[] items = new int[] { 1, 2, 5 };
			string result = items.Select(x => x.ToString()).Aggregate((acc, next) => acc + "," + next);

			Console.WriteLine(result);
		}
		private static void DEMO06()
		{
			// 取分頁紀錄, 假設一頁有三筆, 取第二頁(即 4~6 筆)
			int[] items = new int[] { 1, 50, 60, 13, 435, 54, 11, 5 };
			var secondPage = items.Skip(3).Take(3);
			foreach(var item in secondPage)
			{
				Console.WriteLine(item);
			}
		}
	}
}
