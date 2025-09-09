namespace Easy.TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            var diff = target - num;

            if (set.TryGetValue(diff, out int value))
            {
                var first = Array.IndexOf(nums, value);

                return [first, Array.IndexOf(nums, num, value != num ? 0 : first + 1)];
            }
            set.Add(num);
        }

        return [];
    }
}