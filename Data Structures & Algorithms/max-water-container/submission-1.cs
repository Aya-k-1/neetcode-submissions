public class Solution {
    public int MaxArea(int[] heights) {
      int l=0,r=heights.Length-1;
      int result=0;
      while(l<r){
        int area=(r-l)*Math.Min(heights[l],heights[r]);
        result=Math.Max(area,result);
        if(heights[l]>heights[r]){
            r--;
        }else if(heights[r]>heights[l]){
            l++;
        }else{
            if(heights[l+1]>heights[r-1]){
                r--;
            }else{
                l++;
            }
        }
      }
        return result;
    }
}
