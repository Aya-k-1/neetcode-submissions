public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int>arrayNum=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(arrayNum.ContainsValue(nums[i])){
                return true;
            }
            arrayNum.Add(i,nums[i]);
        }
        return false;
    }
}