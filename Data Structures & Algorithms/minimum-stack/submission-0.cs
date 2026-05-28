public class MinStack {
    private Stack<int> st;
    private Stack<int> minSt;
    public MinStack() {
        st = new();
        minSt = new();
    }

    public void Push(int val) {
        st.Push(val);
        if (minSt.Count != 0) {
            int min = minSt.Peek();
            minSt.Push(Math.Min(min, val));
        } else {
            minSt.Push(val);
        }
    }

    public void Pop() {
        st.Pop();
        minSt.Pop();
    }

    public int Top() {
        return st.Peek();
    }

    public int GetMin() {
        return minSt.Peek();
    }
}
