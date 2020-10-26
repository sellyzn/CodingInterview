using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    public class MirrorTree27
    {
        public TreeNode mirrorTree(TreeNode root)
        {
            if (root == null)
                return null;
            var temp = root.left;
            root.left = mirrorTree(root.right);
            root.right = mirrorTree(temp);
            return root;
        }
    }
}
