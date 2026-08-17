public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //统计每个数字的数量
        var count= new Dictionary<int, int>();
        foreach(var num in nums){
            if(count.ContainsKey(num)){
                count[num]++;
            }else{
                count[num]= 1;
            }
        }
        //排出优先级
        var heap= new PriorityQueue<int, int>();
        foreach(var entry in count){
            heap.Enqueue(entry.Key, entry.Value);
            if(heap.Count >k){
                heap.Dequeue();
            }
        }
        //取出数据以返回
        var res= new int[k];
        for(int i=0; i<k; i++){
            res[i]= heap.Dequeue();
        }
        return res;
    }
}
