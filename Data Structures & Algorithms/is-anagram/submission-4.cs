public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        int[] frequency = new int[26];
        for(int i=0;i<s.Length;i++){
            frequency[s[i]-'a']++;
            frequency[t[i]-'a']--;
        }
        foreach(int element in frequency){
            if(element!=0){
                return false;
            }
        }
        return true;
    }
}
