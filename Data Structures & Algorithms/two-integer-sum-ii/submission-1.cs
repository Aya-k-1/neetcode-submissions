public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0, r=numbers.Length-1;
        while(l<r){
            while(l<r && numbers[l]+numbers[r]<target){
                l++;
            }
            while(l<r && numbers[l]+numbers[r]>target){
                r--;
            }
            if(numbers[l]+numbers[r]==target){
                return new int[]{l+1,r+1};
            }
            
        }
        return new int[0];
    }
}
