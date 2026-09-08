public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        Dictionary<char,int> mapS = new Dictionary<char,int>();
        Dictionary<char,int> mapT = new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++){
            if(mapS.ContainsKey(s[i])){
                mapS[s[i]]++;
            }else{
                mapS.Add(s[i],1);
            }
        } 
         for(int i=0;i<s.Length;i++){
            if(mapT.ContainsKey(t[i])){
                mapT[t[i]]++;
            }else{
                mapT.Add(t[i],1);
            }
        } 

        if(mapS.Count()!=mapT.Count()){
            return false;
        }
        foreach(var i in t){
            if(!mapS.ContainsKey(i) || mapS[i]!=mapT[i] ){
                return false;
            }
        }
        return true;
        
    }
}
