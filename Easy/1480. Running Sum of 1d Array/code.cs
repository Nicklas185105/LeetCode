namespace Easy.RunningSumOf1dArray;

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] output = new int[nums.Length];
        output[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            output[i] = nums[i] + output[i - 1];
        }
        return output;
    }
}