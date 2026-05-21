public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> d = new ();
        foreach(int i in nums){
            if(d.Contains(i)){
                return true;
            }else{
                d.Add(i);
            }
        } 
        return false;
    }
}