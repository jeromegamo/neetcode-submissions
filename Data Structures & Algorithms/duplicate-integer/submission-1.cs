public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        int left = 0;
        int right = left + 1; 
        while (right < nums.Length)
        {
               
            if (nums[left] == nums[right])
            {
                return true;
            }
            left++;
            right++;
        }
        return false;
    }
}