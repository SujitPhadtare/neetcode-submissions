public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
            return 0;

        HashSet<int> hs = new HashSet<int>(nums);
        int count = 1;
        int maxCount = 1;
        for (int i = 0; i < nums.Length; i++) {
            if (!hs.Contains(nums[i] - 1)) {
                for (int j = 1; j <= nums.Length; j++) {
                    if (hs.Contains(nums[i] + j)) {
                        count++;
                    } else {
                        if (count > maxCount) {
                            maxCount = count;
                        }
                        count = 1;
                        break;
                    }
                }
            }
            if (count > maxCount) {
                maxCount = count;
            }
            count = 1;
        }

        if (count > maxCount) {
            maxCount = count;
        }
        return maxCount;
    }
}
