public class Solution {
    public int SumOfSquares(int[] nums) {
                int n = nums.Length;
        int sum = 0;

        // 1-indexed iteration
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                int val = nums[i - 1]; // convert to 0-indexed
                sum += val * val;
            }
        }

        return sum;

    }
}