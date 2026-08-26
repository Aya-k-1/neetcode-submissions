public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map= new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            int sous=target-nums[i];
            if(map.ContainsKey(sous)) {
                return new int[] {map[sous],i};
            }
            if(!map.ContainsKey(nums[i])) map.Add(nums[i],i);
        }
        return Array.Empty<int>();
    }
}