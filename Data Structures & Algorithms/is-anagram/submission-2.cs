public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] charsS = s.ToCharArray();
        char[] charsT = t.ToCharArray();

        Array.Sort(charsS);
        Array.Sort(charsT);
        
    if(charsS.Length!=charsT.Length){
        return false;
    }
        for(int i=0;i<charsS.Length;i++){
            if(charsS[i]!=charsT[i]){
                return false;
            }
        }
        return true;
    }
}
