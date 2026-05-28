public class Solution {
    public int EvalRPN(string[] tokens) {
        string operands = "+-*/";
        Stack<int> st = new();
        int temp = 0;
        for (int i = 0; i < tokens.Length; i++) {
            if (operands.Contains(tokens[i])) {
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
                }
            } else {
                st.Push(int.Parse(tokens[i]));
            }
        }

        return st.Pop();
    }
}
