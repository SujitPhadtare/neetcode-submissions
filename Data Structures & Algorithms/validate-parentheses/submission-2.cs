public class Solution {
    public bool IsValid(string s) {
        int len = s.Length;
        if (len % 2 is 1) {
            return false;
        }
        Stack<char> st = new Stack<char>();
        string pushstring = "([{";
        int i = 0;
        while (i < len) {
            if (pushstring.Contains(s[i])) {
                HashPush(s[i], st);
            } else if (st.Any()) {
                char c = st.Pop();
                if (s[i] != c) {
                    return false;
                }
            } else {
                return false;
            }
            i++;
        }

        return !st.Any();
    }

    public void HashPush(char k, Stack<char> st) {
        switch (k) {
            case '{':
                st.Push('}');
                break;

            case '[':
                st.Push(']');
                break;

            case '(':
                st.Push(')');
                break;
            default:
                break;
        }
    }
}
