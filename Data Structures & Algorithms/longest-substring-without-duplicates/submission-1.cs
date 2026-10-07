public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> map = new HashSet<char>();
        int l=0;
        int result=0;
        for(int r=0;r<s.Length;r++){
           while(map.Contains(s[r])){
                map.Remove(s[l]);
                l++;
            }
            map.Add(s[r]);
            result=Math.Max(result,r-l+1);
        }
        return result;
    }
}
