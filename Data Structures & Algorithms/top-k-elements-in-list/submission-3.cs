public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map= new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i],1);
            }else{
                map[nums[i]]++;
            }
        }
     var sorted= map.OrderByDescending(x=>x.Value);
        int[] result=sorted.Take(k).Select(x=>x.Key).ToArray();
        return result;
    }
}
