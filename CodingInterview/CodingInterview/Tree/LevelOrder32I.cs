using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class LevelOrder32I
    {
        public int[] levelOrder(TreeNode root)
        {
            if (root == null)
                return new int[0];
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var ans = new List<int>();
            while (queue != null)
            {
                var node = queue.Dequeue();
                ans.Add(node.val);
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            var res = new int[ans.Count];
            for(var i = 0; i < ans.Count; i++)
            {
                res[i] = ans[i];
            }
            return res;
        }
    }
}
