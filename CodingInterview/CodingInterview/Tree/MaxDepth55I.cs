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
        public int maxDepth1(TreeNode root)
        {
            if (root == null)
                return 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var res = 0;
            while(queue.Count != 0)
            {
                var tmp = new Queue<TreeNode>();
                foreach(var node in queue)
                {
                    if (node.left != null)
                        tmp.Enqueue(node.left);
                    if (node.right != null)
                        tmp.Enqueue(node.right);
                }
                queue = tmp;
                res++;
            }
            return res;
        }
    }
}
