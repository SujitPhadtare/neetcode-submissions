public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int len = nums.Length;
        int[] l = new int[len];
        int[] r = new int[len];
        int[] res = new int[len];

        for(int i = 0; i< len; i++){
            if(i != 0){
                leftCal(i,l, nums[i-1]);
            }else{
                l[i] = 1;
            }

            int j = len-1 - i;

            if(j != len-1){
                 rightCal(j, r,nums[j+1]);
            }else{
                r[j] = 1 ;
            }
        }

        for(int i=0; i<len;i++){
            res[i] = l[i]*r[i];
        }
        return res;

    }

    public void leftCal(int i, int[] l,int num){
        l[i] = l[i-1]*num;
    }

    public void rightCal(int i, int[] r,int num){
        r[i] = r[i+1]*num;
    }
}
