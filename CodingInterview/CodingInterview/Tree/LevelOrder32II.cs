using System;
using System.Collections.Generic;
using System.Text;

namespace CodingInterview.Tree
{
    public class LevelOrder32II
    {
        public IList<IList<int>> levelOrder(TreeNode root)
        {            
            var queue = new Queue<TreeNode>();
            var res = new List<IList<int>>();
            if (root != null)
                queue.Enqueue(root);
            while(queue.Count > 0)  //wrong: queue != null
            {
                var tmp = new List<int>();
                var len = queue.Count;
                while(len-- > 0)
                {
                    var node = queue.Dequeue();
                    tmp.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                res.Add(tmp);
            }
            return res;
        }
        public IList<IList<int>> levelOrder1(TreeNode root)
        {
            ////边界条件判断
            //if (root == null)
            //    return new List<IList<int>>();
            //队列
            var queue = new Queue<TreeNode>();
            var res = new List<IList<int>>();
            //根节点入队
            queue.Enqueue(root);
            //如果队列不为空就继续循环
            while (queue.Count > 0)
            {
                //BFS打印，levelNum表示的是每层的结点数
                var levelNum = queue.Count;
                //subList存储的是每层的结点值
                var subList = new List<int>();
                for (var i = 0; i < levelNum; i++)
                {
                    //出队
                    var node = queue.Dequeue();
                    subList.Add(node.val);
                    //左右子节点如果不为空就加入到队列中
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                //把每层的结点值存储在res中，
                res.Add(subList);
            }
            return res;
                        
        }
    }
}
