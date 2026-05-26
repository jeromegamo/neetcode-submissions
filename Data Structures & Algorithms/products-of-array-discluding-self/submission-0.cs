public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] postfix = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                prefix[i] = nums[i] * 1;
                continue;
            }

            prefix[i] = prefix[i - 1] * nums[i]; 
        }

        for (int i2 = nums.Length - 1;i2 >= 0;i2--)
        {
            if (i2 == nums.Length - 1)
            {
                postfix[i2] = nums[i2] * 1;
                continue;
            }

            postfix[i2] = postfix[i2 + 1] * nums[i2];
        }

        int[] results = new int[nums.Length];
        for (int i3 = 0; i3 < nums.Length; i3++)
        {
            if (i3 == 0)
            {
                results[i3] = 1 * postfix[i3+1];
                continue;
            }

            if (i3 == nums.Length - 1)
            {
                results[i3] = prefix[i3 - 1] * 1;
                continue;
            }

            results[i3] = prefix[i3 - 1] * postfix[i3 + 1];

        }

        return results;
    }
}
