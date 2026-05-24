public class Solution {
    public int MaxProfit(int[] prices) {
        int len = prices.Length;
        int[] l = new int[len];
        int[] r = new int[len];
        int p = 0;
        int mp = 0;
        for (int i = 0; i < len; i++) {
            if (i == 0) {
                l[i] = prices[i];
            } else {
                l[i] = Math.Min(l[i - 1], prices[i]);
            }

            int j = len - i - 1;

            if (j == (len - 1)) {
                r[j] = prices[j];
            } else {
                r[j] = Math.Max(r[j + 1], prices[j]);
            }
        }

        for (int i = 0; i < len; i++) {
            p = r[i] - l[i];
            if (mp < p) {
                mp = p;
            }
        }
        return mp;
    }
}
