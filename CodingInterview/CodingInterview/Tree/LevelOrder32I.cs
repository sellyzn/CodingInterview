using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    class LevelOrder32I
    {

        public int[] levelOrder(TreeNode root)
        {
            if (root == null)  //special case
                return new int[0];
            var queue = new Queue<TreeNode>();  //initialization
            queue.Enqueue(root);   //initialization
            var ans = new List<int>();   //apply a dynamic array to store nodes value
            while (queue.Count > 0)   //BFS loop  wrong:queue != null
            {
                var node = queue.Dequeue();  //dequeue
                ans.Add(node.val);  //add node value to dynamic array
                if (node.left != null)
                    queue.Enqueue(node.left);  //enqueue left node 
                if (node.right != null)
                    queue.Enqueue(node.right);  //enqueue right node
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
