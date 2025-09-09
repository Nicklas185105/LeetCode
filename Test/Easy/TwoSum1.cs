using Easy.TwoSum;

namespace Test.Easy;

public class TwoSum1
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
        int[] nums = [2, 7, 11, 15];
        int target = 9;

        int[] expected = [0, 1];

        int[] actual = solution.TwoSum(nums, target);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case2()
    {
        int[] nums = [3, 2, 4];
        int target = 6;

        int[] expected = [1, 2];

        int[] actual = solution.TwoSum(nums, target);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case3()
    {
        int[] nums = [3, 3];
        int target = 6;

        int[] expected = [0, 1];

        int[] actual = solution.TwoSum(nums, target);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case4()
    {
        int[] nums = [2, 5, 5, 11];
        int target = 10;

        int[] expected = [1, 2];

        int[] actual = solution.TwoSum(nums, target);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case5()
    {
        int[] nums = [3, 2, 3];
        int target = 6;

        int[] expected = [0, 2];
        int[] actual = solution.TwoSum(nums, target);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case6()
    {
        int[] nums = [0, 4, 3, 0];
        int target = 0;

        int[] expected = [0, 3];
        int[] actual = solution.TwoSum(nums, target);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
