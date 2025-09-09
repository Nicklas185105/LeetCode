using Easy.ContainsDuplicate;

namespace Test.Easy;

public class ContainsDuplicate217
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
        int[] nums = [1, 2, 3, 1];

        bool expected = true;

        bool actual = solution.ContainsDuplicate(nums);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case2()
    {
        int[] nums = [1, 2, 3, 4];

        bool expected = false;

        bool actual = solution.ContainsDuplicate(nums);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case3()
    {
        int[] nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2];

        bool expected = true;

        bool actual = solution.ContainsDuplicate(nums);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
