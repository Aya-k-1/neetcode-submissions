public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for(int i=0;i<numbers.Length;i++){
            int complement = target - numbers[i];
            int complementIndex = Array.IndexOf(numbers,complement,i+1);
            if(complementIndex != -1 ){
                return new int[]{i+1,complementIndex+1};
            }
        }
        return new int[0];
    }
}
