public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> map = new Dictionary<string, List<string>>();
        foreach (var s in strs){
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedS= new string(charArray);
            if(!map.ContainsKey(sortedS)){
                map[sortedS] = new List<string>();
            }
            map[sortedS].Add(s);
        }
        return map.Values.ToList<List<string>>();
    }
}
