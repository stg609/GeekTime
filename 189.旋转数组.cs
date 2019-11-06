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
        int temp = -1;
        int count = 0;
        for (int start = 0; count < nums.Length; start++)
        {
            int current = start;
            int prevData = nums[current];

            do
            {
                //根据当前元素坐标计算目标位置
                int targetLocation = (current + k) % nums.Length;

                temp = nums[targetLocation];
                nums[targetLocation] = prevData;

                prevData = temp;

                //由于目标位置的元素被替代了，所以接下来为这个被替代的元素寻找目标位置
                current = targetLocation;

                //已经执行的元素个数
                count++;
            }
            while (current != start);
        }
    }
}
// @lc code=end


