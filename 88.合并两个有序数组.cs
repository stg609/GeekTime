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
        int p1 = m - 1;
        int p2 = n - 1;

        int last = nums1.Length == 1 ? 0 : m + n - 1;

        while (p2 >= 0 && last >= 0)
        {
            if (p1 < 0)
            {
                nums1[last] = nums2[p2];
                p2--;
            }
            else if (nums1[p1] >= nums2[p2])
            {
                nums1[last] = nums1[p1];
                p1--;
            }
            else if (nums1[p1] < nums2[p2])
            {
                nums1[last] = nums2[p2];
                p2--;
            }

            last--;
        }
    }
}
// @lc code=end

