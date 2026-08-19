public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> mapS = new Dictionary<char,int>();
        Dictionary<char,int> mapT = new Dictionary<char,int>();
        char[] arrS = s.ToCharArray();
        char[] arrT = t.ToCharArray();
        for(int i=0;i<s.Length;i++){
            if(!mapS.ContainsKey(arrS[i])){
                 mapS.Add(arrS[i],1);
            }
           mapS[arrS[i]]++;
        }
        for(int i=0;i<t.Length;i++){
            if(!mapT.ContainsKey(arrT[i])){
                mapT.Add(arrT[i],1);
            }
            mapT[arrT[i]]++;
        }
        if(mapS.Count!=mapT.Count)
        return false;

        foreach(var key in mapS.Keys){
            if(!mapT.ContainsKey(key) || mapS[key]!=mapT[key])
            return false;
        }
        return true;
    }
}