public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        int l = strs.Length;
        
        Dictionary<string,int> hs = new();
        List<List<string>> result = new();
        int count = 0; 
        
        for(int i = 0; i<l; i++){
            char[] arr1 = strs[i].ToCharArray();
            Array.Sort(arr1);
string arr = new String(arr1);
            if(!hs.ContainsKey(arr)){
                hs[arr] = count++;
                List<string> r1 = new();
                r1.Add(strs[i]);  
                result.Add(r1);              
            }else{
                int index = hs[arr];
                result[index].Add(strs[i]);
            }
        }

        return result;
    }
}
