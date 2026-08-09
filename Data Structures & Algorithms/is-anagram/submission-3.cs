public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!= t.Length){
            return false;
        }

        int[] count= new int[26];
        for(int i=0; i<s.Length; i++){ //统计每个字母的出现次数
            count[s[i]-'a']++; //在s出现增一
            count[t[i]-'a']--; //在t中出现则减一
        }
        //对26个字母的位置统计，如果全为0则是有相同字母
        foreach(int val in count){
            if(val !=0){
                return false;
            }
        }
        return true;
    }
}
