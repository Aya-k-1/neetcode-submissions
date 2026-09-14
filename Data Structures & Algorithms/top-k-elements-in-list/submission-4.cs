public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(map.ContainsKey(nums[i])){
                map[nums[i]]++;
            }else{
                map.Add(nums[i],1);
            }
        }
        var sorted = map.OrderByDescending(x=>x.Value);
        int[] result=sorted.Take(k).Select(x=>x.Key).ToArray();
        return result;
    }
}
