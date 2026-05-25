public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        
        Dictionary<char, int> sCount = new();
        Dictionary<char, int> tCount = new();
        foreach(var c in s)
        {
            if (sCount.ContainsKey(c))
            {
                sCount[c] = sCount[c] + 1;
            }
            else
            {
                sCount[c] = 1;
            }
        }

        foreach(var c in t)
        {
            if (tCount.ContainsKey(c))
            {
                tCount[c] = tCount[c] + 1;
            }
            else
            {
                tCount[c] = 1;
            }
        }

        foreach(var (key, value) in sCount)
        {
            if (!tCount.ContainsKey(key))
            {
                return false;
            }

            if (value != tCount[key])
            {
                return false;
            }
        }

        return true;
    }
}
