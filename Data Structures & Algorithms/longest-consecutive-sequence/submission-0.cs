public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0){
            return 0;
        }

        Array.Sort(nums);

        int length=0;
        int curr = nums[0];
        int streak =0;
        int i=0;

        
        while(i<nums.Length){
            if(curr!=nums[i]){
                curr=nums[i];
                streak=0;
            }
            while(i<nums.Length && nums[i]==curr){
                i++;
            }
            streak++;
            curr++;
            length = Math.Max(length,streak);
        }
        return length;
    }
}
