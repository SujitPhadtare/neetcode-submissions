public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s2.Length < s1.Length)
            return false;
        int[] a1 = new int[26];
        int[] a2 = new int[26];

        int len = s1.Length;
        for(int i = 0;i<len;i++){
            a1[s1[i]-'a']++;
            a2[s2[i]-'a']++;
        }
        for(int i = len;i< s2.Length;i++){
            if(CompareArray(a1,a2)){
                return true;
            }
            a2[s2[i]-'a']++;
            a2[s2[i-len]-'a']--;
        }
        return CompareArray(a1,a2);
    }

    private bool CompareArray(int[] a, int[] b){
        for(int i = 0; i< 26; i++){
            if(a[i] != b[i]){
                return false;
            }
        }
        return true;
    }
}
