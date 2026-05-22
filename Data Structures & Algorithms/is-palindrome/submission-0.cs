public class Solution {
    public bool IsPalindrome(string s) {
        char[] chars = s.ToCharArray();
        int len = s.Length;
        int st = 0;
        int e = len - 1;
        while (st < e) {
            if (char.IsLetterOrDigit(s[st]) && char.IsLetterOrDigit(s[e])) {
                if (char.ToLower(s[st]) != char.ToLower(s[e])) {
                    return false;
                }
                e--;
                st++;
            } else {
                if (!char.IsLetterOrDigit(s[st])) {
                    st++;
                }
                if (!char.IsLetterOrDigit(s[e])) {
                    e--;
                }
            }
        }
        return true;
    }
}
