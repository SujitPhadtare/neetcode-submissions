public class Solution {
    public int Trap(int[] height) {
        int len = height.Length;
        if(len is 0 || len is 1){
            return 0;
        }
        int[] l = new int[len];
        int[] r = new int[len];
        int w = 0;

        for(int i = 0; i<len;i++){
            if(i == 0){
                l[i] = height[i];
            }else{
                l[i] = Math.Max(l[i-1],height[i]);
            }
            int j = len - i-1;
            if(j == len-1){
                r[j] = height[j];
            }else{
                r[j] = Math.Max(r[j+1],height[j]);
            }
        }

        for(int i=0; i<len;i++){
            w += Math.Min(l[i], r[i])-height[i];
        }

return w;
    }
}