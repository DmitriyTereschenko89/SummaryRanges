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
					if (nums[fast] - nums[fast - 1] > 1)
					{
						if (fast - 1 == slow)
						{
							summaryRanges.Add($"{nums[slow]}");
						}
						else
						{
							summaryRanges.Add($"{nums[slow]}->{nums[fast]}");
						}
						slow = fast;
					}
				}
				return summaryRanges;
			}
		}
		static void Main(string[] args)
		{
			RangesSummary rangesSummary = new();
            Console.WriteLine(string.Join(", ", rangesSummary.SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 })));
			Console.WriteLine(string.Join(", ", rangesSummary.SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 })));
		}
	}
}