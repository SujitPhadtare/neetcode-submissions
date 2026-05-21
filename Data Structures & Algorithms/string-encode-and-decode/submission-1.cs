public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded = new();
        foreach(string str in strs){
            encoded.Append(str.Length + "#"+str);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        List<string> strs = new();
        int st = 0;
        char h = '#';

        int len = s.Length;
        while(st < len){
            int j = s.IndexOf(h,st);
            string numstr = s.Substring(st,j-st);
            int num = int.Parse(numstr);
            string str = s.Substring(j+1,num);
            strs.Add(str);
            st = j+num+1;
        }
        return strs;
   }
}
