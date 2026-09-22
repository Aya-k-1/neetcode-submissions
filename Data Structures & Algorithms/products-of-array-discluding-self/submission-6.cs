public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output=new int[nums.Length];
        int product=1;
        for(int i=0;i<nums.Length;i++){
         output[i]=product;
         product*=nums[i];
        }

        product=1;
        for(int i=nums.Length-1;i>=0;i--){
            output[i]*=product;
            product *=nums[i];
        }
        return output;
    }
}
