using Easy.KidsWithTheGreatestNumberOfCandies;

namespace Test.Easy;

public class KidsWithTheGreatesNumberOfCandies1431
{
    Solution solution;

    [SetUp]
    public void Setup()
    {
        solution = new Solution();
    }

    [Test]
    public void Case1()
    {
        int[] candies = [2, 3, 5, 1, 3];
        int extraCandies = 3;

        List<bool> expected = [true, true, true, false, true];

        List<bool> actual = solution.KidsWithCandies(candies, extraCandies);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case2()
    {
        int[] candies = [4, 2, 1, 1, 2];
        int extraCandies = 1;

        List<bool> expected = [true, false, false, false, false];

        List<bool> actual = solution.KidsWithCandies(candies, extraCandies);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case3()
    {
        int[] candies = [12, 1, 12];
        int extraCandies = 10;

        List<bool> expected = [true, false, true];

        List<bool> actual = solution.KidsWithCandies(candies, extraCandies);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
