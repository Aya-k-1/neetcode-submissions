public class Solution {
    public int MaxProfit(int[] prices) {
       int l=0,r=1;
       int profit=0;
       int result=0;
       while(r<prices.Length){
        if(prices[l]<prices[r]){
            profit=prices[r]-prices[l];
            result=Math.Max(result,profit);
        }else{
           l=r;
            
        }
        r++;
       } 
       return result;
    }
}
