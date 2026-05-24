public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length is 0) {
            return 0;
        }
        if (s.Length is 1) {
            return 1;
        }
        int ml = 1;
        int l = 1;
        int a = 0;

        for (int i = 1; i < s.Length; i++) {
            string sub = s.Substring(a, i - a);
            char c = s[i];
            if (sub.Contains(c)) {
                for (int j = 0; j < sub.Length; j++) {
                    if (sub[j] == c) {
                        a += j + 1;
                        break;
                    }
                }
                ml = Math.Max(ml,l);
                l=i-a+1;
            } else {
                l++;
            }
        }
 ml = Math.Max(ml,l);
        return ml;
    }
}
