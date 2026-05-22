public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(num.Length == 0){
            return 0;
        }
        int count = 1;
        int maxCount = 1;
        Array.Sort(nums);
        for(int i = 0;i<nums.Length-1;i++){
            if(nums[i]+1 == nums[i+1]){
                count++;
            }else if(nums[i] == nums[i+1]){

            }else{
                if(maxCount < count){
                    maxCount = count;
                }
                count = 1;
            }
        }
                if(maxCount < count){
                    maxCount = count;
                }
        return maxCount;
    }
}
