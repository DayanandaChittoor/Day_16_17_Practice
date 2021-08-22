using System;

namespace BinarySearchString
{
    class Program
    {
		static int binarySearch(string[] arr, string x)
		{
			int l = 0, r = arr.Length - 1;
			while (l <= r)
			{
				int m = l + (r - l) / 2;

				int res = x.CompareTo(arr[m]);

				if (res == 0)
					return m;

				if (res > 0)
					l = m + 1;

				else
					r = m - 1;
			}

			return -1;
		}

		static void Main(string[] args)
		{
			string[] arr = { "contribute", "geeks", "ide", "practice" };
			string x = "ide";
			int result = binarySearch(arr, x);

			if (result == -1)
				Console.WriteLine("Element not present");

			else
				Console.WriteLine("Element is found at "+ result);
		}
	}
}
