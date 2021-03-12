using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.TreeProblems
{
    public class IsBalanced55II
    {
        //后序遍历+剪枝（从底至顶）
        public bool isBalanced(TreeNode root)
        {
            return recur(root) != -1;
        }

        //用left，right记录root左右子节点的深度，避免遍历root时对左右节点的深度进行重复计算。
        //考虑到需要同时记录各个节点的深度和其是否符合平衡性要求，这里的返回值设为int,用一个特殊值-1来表示出现不平衡的节点的情况，而不是一般采用的boolean
        private int recur(TreeNode root)
        {
            // 用后序遍历的方式遍历二叉树的每个节点（从底至顶）,先左子树，再右子树，最后根节点，
            if (root == null)
                return 0;   //root等于0时，该节点符合要求，返回其深度0，而不返回-1；
            var left = recur(root.left);//left最开始的取值为0，从底朝上遍历，先左子树，后右子树，最后根节点
            if (left == -1)//若出现节点的深度为-1，则进行剪枝，开始向上返回，之后的迭代不再进行
                return -1;
            var right = recur(root.right);
            if (right == -1)
                return -1;
            return Math.Abs(left - right) < 2 ? Math.Max(left, right) + 1 : -1;//+1不能少
            //最开始计算的是左子树最左侧的一个叶节点，其左右子节点不存在，left=0，right=0，满足条件，返回该叶节点的深度max(0,0)+1=1;
        }

        //先序遍历+判断深度（从顶至底）
        public bool isBalanced1(TreeNode root)
        {
            if (root == null)
                return true;
            return Math.Abs(depth(root.left) - depth(root.right)) <= 1 && isBalanced(root.left) && isBalanced(root.right);
        }
        public int depth(TreeNode root)
        {
            if (root == null)
                return 0;
            return Math.Max(depth(root.left), depth(root.right)) + 1;
        }
    }
}
