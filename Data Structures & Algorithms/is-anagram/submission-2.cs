public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> counter = new();
        
        int index = 0;
        while (index < s.Length)
        {
            if (!counter.ContainsKey(s[index]))
            {
                counter.Add(s[index], 0);
            }

            if (!counter.ContainsKey(t[index]))
            {
                counter.Add(t[index], 0);
            }
         
            counter[s[index]]++;
            counter[t[index]]--;

            index++;
        }

        foreach (var v in counter.Values)
        {
            if (v != 0)
            {
                return false;
            }
        }

        return true;
    }
}
