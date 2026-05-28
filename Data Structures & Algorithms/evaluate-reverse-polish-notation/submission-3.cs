public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new();
        int temp = 0;
        for (int i = 0; i < tokens.Length; i++) {
            switch (tokens[i]) {
                case "+":
                    st.Push(st.Pop() + st.Pop());
                    break;

                case "-":
                    temp = st.Pop();
                    st.Push(st.Pop() - temp);
                    break;

                case "*":
                    st.Push(st.Pop() * st.Pop());
                    break;

                case "/":
                    temp = st.Pop();
                    st.Push(st.Pop() / temp);
                    break;
                default:
                    st.Push(int.Parse(tokens[i]));
                    break;
            }
        }
        return st.Pop();
    }
}
