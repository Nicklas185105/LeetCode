using Easy.ValidAnagram;

namespace Test.Easy;

public class ValidAnagram242
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
        string s = "anagram", t = "nagaram";

        bool expected = true;

        bool actual = solution.IsAnagram(s, t);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Case2()
    {
        string s = "rat", t = "car";

        bool expected = false;

        bool actual = solution.IsAnagram(s, t);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
