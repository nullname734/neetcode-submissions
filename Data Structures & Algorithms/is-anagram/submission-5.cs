public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        char[] sSoted = s.ToCharArray();
        char[] tSorted = t.ToCharArray();
        Array.Sort(sSoted);
        Array.Sort(tSorted);
        return new string(sSoted).Equals(new string(tSorted));
    }
}
