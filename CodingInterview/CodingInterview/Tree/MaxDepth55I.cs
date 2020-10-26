using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    public class MaxDepth55I
    {
        //DFS
        public int maxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else
                return Math.Max(maxDepth(root.left),maxDepth(root.right)) + 1;
        }

        //LFS

    }
}
