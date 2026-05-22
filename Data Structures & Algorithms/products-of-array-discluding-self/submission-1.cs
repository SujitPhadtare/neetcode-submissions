public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int len = nums.Length;
        int[] l = new int[len];
        int[] r = new int[len];
        int[] res = new int[len];

        for(int i = 0; i< len; i++){
            if(i != 0){
                l[i]  = calPro(0,i-1, nums);
            }else{
                l[i] = 1;
            }
            if(i != len-1){
                r[i] = calPro(i+1,len-1, nums);
            }else{
                r[i] = 1 ;
            }
            res[i] = l[i] * r[i];
        }
        return res;

    }

    public int calPro(int s, int e, int[] nums){
        int res = 1;
        for(int i = s;i<=e;i++){
            res *= nums[i];
        }
        return res;
    }
}
