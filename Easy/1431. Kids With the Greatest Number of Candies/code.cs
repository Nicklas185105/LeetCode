namespace Easy.KidsWithTheGreatestNumberOfCandies;

public class Solution
{
    public List<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> output = [];
        int maxValue = candies.Max();
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= maxValue) output.Add(true);
            else output.Add(false);
        }
        return output;
    }
}