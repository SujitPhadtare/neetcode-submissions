public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) 
            return false;

        char[] sc = s.ToCharArray();
        char[] tc = t.ToCharArray();

        Array.Sort(sc);
        Array.Sort(tc);

        s = new string(sc);
        t = new string(tc);

        return s == t;
        
    }
}
