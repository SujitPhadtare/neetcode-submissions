public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hm = new();
        int l = nums.Length; 
        
        for(int i = 0; i<l; i++){
            hm[target - nums[i]] = i;
        }

        //check here
        for(int i = 0; i<l; i++){
            if(hm.ContainsKey(nums[i])){
                int j = hm[nums[i]];
                if(i != j){
                    return [i,j];
                }
            }
        }
        return [0,0];
    }
}
