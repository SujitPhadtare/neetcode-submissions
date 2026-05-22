public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> hm = new();
        for (int i = 0; i < numbers.Length; i++) {
            int key = target - numbers[i];
            if (!hm.ContainsKey(key))
                hm[key] = i;
        }

        for(int i = 0;i<numbers.Length;i++){
            if(hm.ContainsKey(numbers[i])){
                int key = hm[numbers[i]];
                if(key<i){
                    return [key+1,i+1];
                }else{
                    return [i+1,key+1];
                }
            }
        }
        return [0,0];
    }
}
