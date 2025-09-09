using Easy.RunningSumOf1dArray;

namespace Test.Easy;

public class RunningSumOf1dArray1480
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
        int[] nums = [1, 2, 3, 4];

        int[] expected = [1, 3, 6, 10];

        int[] actual = solution.RunningSum(nums);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case2()
    {
        int[] nums = [1, 1, 1, 1, 1];

        int[] expected = [1, 2, 3, 4, 5];

        int[] actual = solution.RunningSum(nums);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case3()
    {
        int[] nums = [3, 1, 2, 10, 1];

        int[] expected = [3, 4, 6, 16, 17];

        int[] actual = solution.RunningSum(nums);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
