public class Solution {
    public int LongestConsecutive(int[] nums) {

        HashSet<int> hs = new HashSet<int>(nums);

        int maxCount = 0;

        foreach(int num in hs)
        {
            // Start only if this is beginning of sequence
            if(!hs.Contains(num - 1))
            {
                int current = num;
                int count = 1;

                // Expand sequence
                while(hs.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                maxCount = Math.Max(maxCount, count);
            }
        }

        return maxCount;
    }
}