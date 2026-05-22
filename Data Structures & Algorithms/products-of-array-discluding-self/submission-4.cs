public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        int[] r = new int[len];
        int[] res = new int[len];

        for (int i = 0; i < len; i++) {
            if (i != 0) {
                res[i] = res[i - 1] * nums[i - 1];
            } else {
                res[i] = 1;
            }

            int j = len - 1 - i;
            if (j != len - 1) {
                r[j] = r[j + 1] * nums[j + 1];

            } else {
                r[j] = 1;
            }
        }

        for (int i = 0; i < len; i++) {
            res[i] = res[i] * r[i];
        }
        return res;
    }
}
