public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new();
        foreach (var word in strs)
        {
            int[] count = new int[26];
            foreach (var ch in word)
            {
                int k = ch - 'a';
                count[k]++;
            }

            string key = string.Join(",", count);
            if (groups.ContainsKey(key))
            {
                groups[key].Add(word);
            }
            else
            {
                groups.Add(key, new List<string>() { word });
            }
        }
        return groups.Values.ToList();
    }
}
