public class Solution {
    public bool IsPalindrome(string s) {
       
        s=s.ToLower();
        s=s.Replace(" ","");
         string modifiedS = new string(s.Where(char.IsLetterOrDigit).ToArray());
        char[] sArr=modifiedS.ToCharArray();
        char[] sArrReversed=sArr.Reverse().ToArray();
        for(int i=0;i<sArr.Length;i++){
            if(sArr[i]!=sArrReversed[i]){
                return false;
            }
        }
        return true;
    }
}
