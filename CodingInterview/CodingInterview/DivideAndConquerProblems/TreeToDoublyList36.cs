using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.DivideAndConquerProblems
{
    public class TreeToDoublyList36
    {
        //

        /*
        
        解题思路：

        排序：二叉搜索树的中序遍历： 1，2，3，4，5
        双向：不仅 2.right = 3, 还有 3.left = 2
        循环：5.right = 1, 1.left = 5

        基于性质：二叉搜索树的中序遍历为递增序列。
        将二叉搜索树转换成一个排序的循环双向链表：
        1. 排序链表：中序遍历访问树的节点
        2. 双向链表：在构建相邻节点的引用关系时，设前驱节点 pre 和当前节点 cur， 不仅构建 pre.right = cur, 也应构建 cur.left = pre。
        3. 循环链表：设链表头节点head和尾节点tail,则应构建 head,left = tail 和 tail.right = head。

        算法流程：
        dfs(cur)：递归法中序遍历：
            1.终止条件：当节点为空，代表越过叶节点，直接返回；
            2.递归左子树，即dfs(cur.left)；
            3.构建链表：
                1.当 pre 为空时：代表正在访问链表头节点，记为 head；
                2.当 pre 不为空时：修改双向节点引用，即 pre.right = cur, cur.left = pre；
                3.保存 cur：更新 pre = cur，即节点cur是后继节点的pre；
            4.递归右子树，即dfs(cur.right)；

        TreeToDoublyList(root)：
            1.特例处理：若节点root为空，则直接返回；
            2.初始化：空姐点pre；
            3.转化为双向链表：调用dfs(root)；
            4.构建循环链表：中序遍历完成后，head指向头节点，pre指向尾节点，因此修改head和pre的双向节点引用即可；
            5.返回值：返回链表的头节点 head。

         */
        Node pre, head;
        public Node TreeToDoublyList(Node root)
        {
            if(root == null)
                return null;
            DFS(root);
            head.left = pre;
            pre.right = head;
            return head;
        }
        public void DFS(Node cur)
        {
            if (cur == null)
                return;
            DFS(cur.left);

            if (pre != null)
                pre.right = cur;
            else
                head = cur;
            cur.left = pre;
            pre = cur;

            DFS(cur.right);
        }
    }
}
