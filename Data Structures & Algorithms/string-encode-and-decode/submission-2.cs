public class Solution {

    public string Encode(IList<string> strs) {
        string encoded_string= "";
        for(int i=0;i<strs.Count;i++){
                encoded_string+=strs[i].Length.ToString()+"#"+strs[i];
        }
        return encoded_string;
    }

    public List<string> Decode(string s) {
        List<string> decoded_strs = new List<string>();
        int i=0;
        while(i<s.Length){
            int j=i;
            while(s[j]!='#'){
                j++;
            }
            int length = int.Parse(s.Substring(i,j-i));
            string word= s.Substring(j+1,length);
            decoded_strs.Add(word);
            i=j+length+1;
        }
        return decoded_strs;
   }
}
