using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    public class MirrorTree27
    {
        //DFS
        public TreeNode mirrorTree(TreeNode root)
        {
            if (root == null)
                return null;
            var temp = root.left;
            root.left = mirrorTree(root.right);
            root.right = mirrorTree(temp);
            return root;
        }

        //use temp Stack/Queue
        public TreeNode mirrorTree1(TreeNode root)
        {
            if (root == null)
                return null;
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while(stack.Count != 0)
            {
                var node = stack.Pop();
                if (node.left != null)
                    stack.Push(node.left);
                if (node.right != null)
                    stack.Push(node.right);
                var tmp = node.left;
                node.left = node.right;
                node.right = tmp;
            }
            return root;
        }
    }
}
