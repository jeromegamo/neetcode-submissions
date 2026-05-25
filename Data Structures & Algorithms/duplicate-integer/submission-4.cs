public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, bool> visited = new();
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            if (nums[left] == nums[right])
            {
                return true;
            }
            else if (visited.ContainsKey(nums[left]) ||
                visited.ContainsKey(nums[right]))
            {
                return true;
            }
            else
            {
                visited.TryAdd(nums[left], true);
                visited.TryAdd(nums[right], true);
            }
            left++;
            right--;
        }
        return false;
    }
}