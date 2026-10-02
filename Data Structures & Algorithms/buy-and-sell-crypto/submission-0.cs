public class Solution {
    public int MaxProfit(int[] prices) {
        int l=0,r=1;
        int result=0;
        while(r<prices.Length){
        
            if(prices[l]<prices[r]){
                int profit=prices[r]-prices[l];
                result=Math.Max(profit,result);
            }else{
                l=r;
            }
            r++;
        }
        return result;
    }
}
