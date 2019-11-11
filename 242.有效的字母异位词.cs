/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start

using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (!string.IsNullOrEmpty(s + t) && (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)))
        {
            return false;
        }
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> dic = new Dictionary<char, int>();
        foreach (var ch in t)
        {
            if (dic.ContainsKey(ch))
            {
                dic[ch]++;
            }
            else
            {
                dic.Add(ch, 1);
            }
        }
        foreach (var ch in s)
        {
            var contains = dic.SingleOrDefault(itm => itm.Key == ch);
            if (contains.Key == null || contains.Value <= 0)
            {
                return false;
            }

            dic[ch]--;
        }

        return true;
    }
}
// @lc code=end

