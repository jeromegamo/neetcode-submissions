public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var valueCountTracker = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            valueCountTracker[n] = valueCountTracker.GetValueOrDefault(n, 0) + 1;
        }

        var rank = new List<int>[nums.Length + 1];

        foreach (var (value, count) in valueCountTracker)
        {
            if (rank[count] == null)
            {
                rank[count] = new List<int>();
            }
            rank[count].Add(value);
        }

        int kCounter = 0;
        var freq = new int[k];
        for (var i = rank.Length - 1;i > 0; i--)
        {
            if (rank[i] != null)
            {
                foreach (var r in rank[i])
                {
                    
                    freq[kCounter] = r;
                    kCounter++;

                    if (kCounter == k) return freq;
                }
               
            }
        }
        return freq;
    }
}
