/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 */

// @lc code=start
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        //[1,2,3]
        //[2,3,1]
        //k=2
        int[] temp = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + k;
            if (j >= nums.Length)
            {
                j = j % nums.Length;
            }
            //i=2
            temp[j] = nums[i];
        }
    }
}
// @lc code=end


