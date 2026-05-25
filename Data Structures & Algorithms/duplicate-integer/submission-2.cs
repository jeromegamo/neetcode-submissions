public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, bool> visited = new();
        int index = 0;
        while (index < nums.Length)
        {
            if (visited.ContainsKey(nums[index]))
            {
                return true;
            }
            else
            {
                visited.TryAdd(nums[index], true);
            }
            index++;
        }
        return false;
    }
}