using Easy.RemoveDuplicatesFromSortedArray;

namespace Test.Easy;

public class RemoveDuplicatesFromSortedArray26
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
        int[] nums = [1, 1, 2];

        int expected = 2;

        int actual = solution.RemoveDuplicates(nums);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case2()
    {
        int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

        int expected = 5;

        int actual = solution.RemoveDuplicates(nums);

        Assert.That(actual, Is.EqualTo(expected));
    }
}