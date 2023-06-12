namespace SummaryRanges
{
	internal class Program
	{
		public class RangesSummary
		{
			public IList<string> SummaryRanges(int[] nums)
			{
				List<string> summaryRanges = new();
				int n = nums.Length;
				int slow = 0;
				for (int fast = 1; fast < n; ++fast)
				{
					long num1 = nums[fast];
					long num2 = nums[fast - 1];
					if (num1 - num2 > 1)
					{
						summaryRanges.Add(fast - 1 == slow ? $"{nums[slow]}" : $"{nums[slow]}->{nums[fast - 1]}");
						slow = fast;
					}
				}
				summaryRanges.Add(slow == n - 1 ? $"{nums[slow]}" : $"{nums[slow]}->{nums[n - 1]}");
                return summaryRanges;
			}
		}
		static void Main(string[] args)
		{
			RangesSummary rangesSummary = new();
            Console.WriteLine(string.Join(", ", rangesSummary.SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 })));
			Console.WriteLine(string.Join(", ", rangesSummary.SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 })));
            Console.WriteLine(string.Join(", ", rangesSummary.SummaryRanges(new int[] { -2147483648, -2147483647, 2147483647 })));
        }
	}
}