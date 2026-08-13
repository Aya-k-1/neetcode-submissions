public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int[]> list = new List<int[]>();
        for(int index=0;index<nums.Length;index++){
            list.Add(new int[]{nums[index],index});
        }
       list.Sort((a,b)=>a[0].CompareTo(b[0]));

        int i=0, j=nums.Length-1;
        while(i<j){
            int current = list[i][0]+list[j][0];
            if(current==target){
                return new int[]{
                    Math.Min(list[i][1],list[j][1]),
                    Math.Max(list[i][1],list[j][1])
                };
            }else if(current<target){
                i++;
            }else{
                j--;
            }
        }
        return new int[0];
    }
}
