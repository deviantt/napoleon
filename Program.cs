using System;

namespace napoleon
{
	class Program
	{
		static void Main(string[] args)
		{
			string num = String.Empty;
			int[] arr = new int[] { };
			do
			{
				num = Console.ReadLine();
				if (num[0] == '+') break;
				else
				{
					Array.Resize<int>(ref arr, arr.Length + 1); 
					arr[arr.Length - 1] = Convert.ToInt32(num);
				}
			} while (num[0] != '+');
			
				int[] Chet = new int[] { };
				int[] NeChet = new int[] { };
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] % 2 == 0)
					{
						Array.Resize<int>(ref Chet, Chet.Length + 1);
						Chet[Chet.Length-1] = arr[i];
						
					}
					else
					{
						Array.Resize<int>(ref NeChet, NeChet.Length + 1);
						NeChet[NeChet.Length-1] = arr[i];
					}
				}
			Chet = BubbleSort(Chet);
				NeChet = BubbleSortU(NeChet);
			for (int i = 0; i < Chet.Length; i++) arr[i] = Chet[i];
				for (int i = 0; i < NeChet.Length; i++) arr[Chet.Length + i] = NeChet[i];
				foreach (int i in arr) Console.WriteLine(i);
			
		}

		static int[] BubbleSort(int[] values)
		{
			for (int i = 0; i < values.Length; i++)
			{
				for (int j = 0; j < values.Length - 1; j++)
				{
					if (values[j + 1] < values[j])
					{
						Swap(ref values[j], ref values[j + 1]);
					}
				}
			}
			return values;
		}
		static int[] BubbleSortU(int[] values)
		{
			int temp;
			for (int i = 0; i < values.Length - 1; i++)
			{
				for (int j = 0; j < values.Length - 1; j++)
				{
						if (values[j] < values[j+1])
						{
						Swap(ref values[j], ref values[j + 1]);

					}

				}
			}
			return values;
		}
		static void Swap(ref int val1, ref int val2)
		{
			int temp;
			temp = val1;
			val1 = val2;
			val2 = temp;
		}
	}
}
