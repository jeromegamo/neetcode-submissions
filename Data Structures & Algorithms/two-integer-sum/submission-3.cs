public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> col = new();

        for (int index = 0; index < nums.Length; index++)
        {
            int diff = target - nums[index];
            if (col.TryGetValue(diff, out var value))
            {
                return [value, index];
            }
            col.TryAdd(nums[index], index);
        }
        return [];
    }
}
