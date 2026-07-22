class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res=defaultdict(list) #创建一个值为空的字典
        for s in strs:
            sortedS=''.join(sorted(s))
            res[sortedS].append(s)
        return list(res.values())

            
        
        