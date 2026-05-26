public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> elements = new(nums);
        int max = 0;
        foreach (var n in nums)
        {
            bool isStartOfSeq = !elements.Contains(n - 1);
            if (isStartOfSeq)
            {
                int length = 0;
                while (elements.Contains(n + length))
                {
                    max = Math.Max(++length, max);
                }
            }
        }

        return max;
    }
}
