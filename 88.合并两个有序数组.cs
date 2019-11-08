/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int totalLen = m;
        if (m == 0)
        {
            for (int index = 0; index < nums2.Length; index++)
            {
                nums1[index] = nums2[index];
            }
            return;
        }
        else if (n == 0)
        {
            return;
        }

        for (int index = m - 1; index >= 0 && n >= 0;)
        {
            var j = GetGreaterIndex(nums2, n, nums1[index]);
            if (j > -1)
            {
                int steps = n - j;
                if (index < m - 1)
                {
                    MoveForward(nums1, totalLen, index + 1, steps);
                }
                for (int x = j; x < n; x++)
                {
                    nums1[index + x + 1 - j] = nums2[x];
                }
                totalLen += steps;
                n -= steps;
            }
            else
            {
                if (index == 0 && n > 0)
                {
                    MoveForward(nums1, totalLen, 0, n);

                    for (int x = 0; x < n; x++)
                    {
                        nums1[x] = nums2[x];
                    }
                }

                index--;
            }
        }
    }

    private int GetGreaterIndex(int[] itms, int len, int num)
    {
        for (int index = 0; index < len; index++)
        {
            if (itms[index] >= num)
            {
                return index;
            }
        }

        return -1;
    }

    private void MoveForward(int[] itms, int len, int startIndex, int steps)
    {
        for (int index = len - 1; index >= startIndex; index--)
        {
            itms[index + steps] = itms[index];
        }
    }
}
// @lc code=end

