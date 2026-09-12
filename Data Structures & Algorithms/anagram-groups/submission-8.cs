public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        for(int i=0;i<strs.Length;i++){
            char[] letters=strs[i].ToCharArray();
            Array.Sort(letters);
           string word= new string(letters);
            if(!map.ContainsKey(word)){
                map.Add(word,new List<string> {strs[i]});
            }else{
                map[word].Add(strs[i]);
            } 
        }
        return map.Values.ToList();
    }
}
