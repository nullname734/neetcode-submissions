public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res= new Dictionary<string, List<string>>();
        foreach(var s in strs){
            char[] charArray= s.ToCharArray();
            Array.Sort(charArray); //对取出来的单词排序
            string sorted= new string(charArray); //键
            if (!res.ContainsKey(sorted))
            {
                res[sorted]=new List<string>(); //新增键
            }
            res[sorted].Add(s); //字典新增值
        }
        return res.Values.ToList<List<string>>(); //返回
    }
}
