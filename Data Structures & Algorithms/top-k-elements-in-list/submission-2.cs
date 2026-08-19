public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> count= new Dictionary<int,int>();
        List<int>[] frequence = new List<int>[nums.Length+1];
        for(int i=0;i<frequence.Length;i++){
            frequence[i]= new List<int>();
        }

        foreach (int n in nums){
            if(count.ContainsKey(n)){
                count[n]++;
            }else{
                count[n]=1;
            }
        }
        foreach (var entry in count){
            frequence[entry.Value].Add(entry.Key);
        }
        int[] res = new int[k];
        int index = 0;
        for(int i= frequence.Length-1;i>0&& index<k;i--){
            foreach(int n in frequence[i]){
                res[index++]=n;
                if(index==k){
                    return res;
                }
            }
        }
        return res;
    }
}
