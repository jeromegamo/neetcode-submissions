public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];

        int i = 0;
        while (i < nums.Length)
        {
            int prefix = GetPrefix(nums, i - 1);
            int postfix = GetPostfix(nums, i + 1);
            result[i] = prefix * postfix;  
            i++;
        }
        return result;
    }

    private int GetPrefix(int[] nums, int currentIndex)
    {
        if (currentIndex < 0)
        {
            return 1;
        }

        return GetPrefix(nums, currentIndex - 1) * nums[currentIndex];
    }

    private int GetPostfix(int[] nums, int currentIndex)
    {
        if (currentIndex >= nums.Length)
        {
            return 1;
        }

        return GetPostfix(nums, currentIndex + 1) * nums[currentIndex]; 
    }
}
