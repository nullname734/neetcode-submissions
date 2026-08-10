public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res= new Dictionary<string, List<string>>();
        foreach(var s in strs){
            int[] count=new int[26]; //仍然记录字母
            foreach(char c in s){
                count[c-'a']++;  //计算字母对应值，第一个寻到的单词做key
            }
            string key= string.Join(",", count); //记录该单词
            if(!res.ContainsKey(key)){  //不存在这个键则新增键值对
                res[key]= new List<string>();
            }
            res[key].Add(s); //将该单词加入到这个key的value当中
        }
        return res.Values.ToList<List<string>>();
    }
}
