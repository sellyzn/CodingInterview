using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.TreeProblems
{
    public class VerifyPostorder33
    {
        // 剑指offer33：二叉搜索树的后续遍历序列
        /* 输入一个整数数组，判断该数组是不是某二叉搜索树的后序遍历结果。
         * 如果是则返回 true，否则返回 false。假设输入的数组的任意两个数字都互不相同。

        参考以下这颗二叉搜索树：

             5
            / \
           2   6
          / \
         1   3

        示例 1：
        输入: [1,6,3,2,5]
        输出: false

        示例 2：
        输入: [1,3,2,6,5]
        输出: true

         */
        public bool VerifyPostorder(int[] postorder)
        {
            return Recursive(postorder, 0, postorder.Length - 1);
        }
        public bool Recursive(int[] postorder, int left, int right)
        {
            if (left >= right)
                return true;
            int root = postorder[right];
            int m = left;
            while (postorder[m] < root)
                m++;
            for(int i = m; i <= right - 1; i++)
            {
                if (postorder[i] <= root)
                    return false;
            }
            return Recursive(postorder, left, m - 1) && Recursive(postorder, m, right - 1);

        }

        /*
         *  **终止条件： 当 i≥j ，说明此子树节点数量 ≤1 ，无需判别正确性，因此直接返回 true ；
            **递推工作：
                1.划分左右子树： 遍历后序遍历的 [i,j] 区间元素，寻找 第一个大于根节点 的节点，索引记为 m 。
                  此时，可划分出左子树区间 [i,m−1] 、右子树区间 [m,j−1] 、根节点索引 j 。
                2.判断是否为二叉搜索树：
                    *左子树区间 [i,m−1] 内的所有节点都应 < postorder[j] 。
                     而第 1.划分左右子树 步骤已经保证左子树区间的正确性，因此只需要判断右子树区间即可。
                    *右子树区间 [m,j−1] 内的所有节点都应 > postorder[j] 。
                     实现方式为遍历，当遇到 ≤postorder[j] 的节点则跳出；则可通过 p=j 判断是否为二叉搜索树。
            **返回值： 所有子树都需正确才可判定正确，因此使用 与逻辑符 && 连接。
                1. p=j ： 判断 此树 是否正确。
                2. recur(i,m−1) ： 判断 此树的左子树 是否正确。
                3. recur(m,j−1) ： 判断 此树的右子树 是否正确。
         */

    }
}
