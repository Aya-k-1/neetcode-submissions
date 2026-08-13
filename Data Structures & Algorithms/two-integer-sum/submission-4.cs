public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> hashset= new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++){
          hashset[nums[i]]=i;
        } 
        int soust=0;
        for(int i=0;i<nums.Length;i++){
            soust=target-nums[i];
            if(hashset.ContainsKey(soust) && hashset[soust]!=i){
                return new int[]{i,hashset[soust]};
            }
        }
        return new int[0];
    }
}
