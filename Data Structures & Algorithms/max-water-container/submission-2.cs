public class Solution {
    public int MaxArea(int[] heights) {
        int w = 0;
        int mw = 0;
        int l = 0;
        int r = heights.Length -1;
        while(l<r){
            int m = Math.Min(heights[l],heights[r]);
            w = (r-l)*m;

            mw = Math.Max(w,mw);
            if(heights[l] < heights[r]){
                l++;
            }else{
                r--;}
        }
        return mw;


    }
}
