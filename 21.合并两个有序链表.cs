/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode temp = null;

        if (l1 == null)
        {
            return l2;
        }
        else if (l2 == null)
        {
            return l1;
        }

        if (l1.val > l2.val)
        {
            //如果 l1 比 l2 大，则把 l2 排在 l1 前面，然后 继续拿 l1 与 l2.next 进行比较
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
        else if (l1.val < l2.val)
        {
            //如果 l1 < l2，则继续拿 l1.next 与 l2 比较
            l1.next = MergeTwoLists(l2, l1.next);
            return l1;
        }
        else
        {
            temp = l1.next;
            l1.next = l2;
            l2.next = MergeTwoLists(temp, l2.next);
            return l1;
        }
    }
}
// @lc code=end