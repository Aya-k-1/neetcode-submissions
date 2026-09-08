public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        char[] arrayS=s.ToCharArray();
        char[] arrayT=t.ToCharArray();

        Array.Sort(arrayS);
        Array.Sort(arrayT);

        for(int i=0;i<arrayS.Length;i++){
            if(arrayS[i]!=arrayT[i]){
                return false;
            }
        }
        return true;
    }
}
