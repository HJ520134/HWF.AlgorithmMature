using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeLearn
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    /// <summary>
    /// 二叉树的最大深度
    /// </summary>
    public class MaxDepth
    {
        public int MaxDepthOne(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var leftLevel = MaxDepthOne(root.left);
            var rightLevel = MaxDepthOne(root.right);
            return Math.Max(leftLevel, rightLevel) + 1;
        }
    }
}
