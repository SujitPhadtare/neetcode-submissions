public class Solution {
    public int MaxProfit(int[] prices) {
        int len = prices.Length;
        int min = prices[0];
        int p = 0;
        int mp = 0;
        for (int i = 1; i < len; i++) {
            
            min = Math.Min(min, prices[i]);

            // Calculate profit
            p = prices[i] - min;

            if (p > mp) {
                mp = p;
            }
        }
        return mp;
    }
}
