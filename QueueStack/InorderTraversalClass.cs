using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn.QueueStack
{
    public class InorderTraversalClass
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int> { };
            if (root == null)
            {
                return result;
            }
            recursive(root, result);
            return result;
        }

        public void recursive(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }
            recursive(node.left, list);
            list.Add(node.val);
            recursive(node.right, list);
        }
    }
}
