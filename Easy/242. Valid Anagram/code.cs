public class Solution {
    public bool IsAnagram(string s, string t) {
		if (s.Length != t.Length) {
			return false;
		}
		var dict = new Dictionary<char, int>();
		foreach (var c in s) {
			if (dict.ContainsKey(c)) {
				dict[c]++;
			} else {
				dict[c] = 1;
			}
		}
		foreach (var c in t) {
			if (dict.ContainsKey(c)) {
				dict[c]--;
				if (dict[c] < 0) {
					return false;
				}
			} else {
				return false;
			}
		}
		return true;

		var s1 = new string(s.ToCharArray().OrderBy(c => c));
		var s2 = new string(t.ToCharArray().OrderBy(c => c));
		Console.WriteLine(s1);
		Console.WriteLine(s2);
		return s1.Equals(s2);
    }
}