public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> elements = new();
        foreach (var n in nums)
        {
            elements.Add(n);
        }

        int max = 0;

        foreach (var n in nums)
        {
            int longestSeq = 1;
            int prev = n - 1;
            int next = n + 1;

            while (elements.Contains(prev))
            {
                longestSeq++;
                prev--;
            }

            while (elements.Contains(next))
            {
                longestSeq++;
                next++;
            }

            max = Math.Max(max, longestSeq);
        }

        return max;
    }
}
