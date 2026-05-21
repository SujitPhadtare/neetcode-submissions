public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int pro = 1;
        int zc = 0;
        int index = 0;
        int len = nums.Count();
        for(int i = 0; i < len; i++){
            if(nums[i] != 0){
            pro *= nums[i];
            }else if (zc == 0){
                zc++;
                index = i;
            }else{
                return new int[len];
            }
        }
int[] r = new int[len];

if(zc == 1){
    r[index] = pro;
    return r;
}
        for(int i = 0; i<len; i++){
            r[i] = pro/nums[i];
        }
        return r;
    }
}
