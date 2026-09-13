public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,string> map = new Dictionary<string,string>();
        Dictionary<string,List<string>> result= new Dictionary<string,List<string>>();
        for(int i=0;i<strs.Length;i++){
            char[] letters = strs[i].ToCharArray();
            int[] count=new int[26];
            for(int j=0;j<letters.Length;j++){
                count[letters[j]-'a']++;
            }
           string countString=String.Join(',',count);
           if(!map.ContainsKey(countString)){
            map.Add(countString,strs[i]);
           }
           if(!result.ContainsKey(countString) ){
                result.Add(countString,new List<string>() {strs[i]});
           }else{
            result[countString].Add(strs[i]);
           }
        }
            return result.Values.ToList();
        
    }
}
