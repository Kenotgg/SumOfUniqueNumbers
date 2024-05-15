using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfUniqueNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//принимаем массив чисел с заданой нужной суммой
			int[] nums = { 1, 2, 3, 4, 5, 6,7,8,9,10};
			int targetSum = 8;
			
			FindUniqueSum(nums, targetSum);

			
			Console.ReadKey();
		}
		static void FindUniqueSum(int[] nums,int targetSum)
		{
			//сумируем каждое число с каждым по принципу текущее с остальными следующими
			int[] proccessedNums = new int[nums.Length];
			for (int j = 0; j < nums.Length - 1; j++)
			{
				for (int i = j; i < nums.Length - 1; i++)
				{
					proccessedNums[i] = nums[j] + nums[i + 1];
					Console.WriteLine(nums[j] + "+" + nums[i + 1] + "=" + proccessedNums[i]);
					//находим число равное нужной сумме
					if (proccessedNums[i] == targetSum)
					{
						Console.WriteLine("True");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
