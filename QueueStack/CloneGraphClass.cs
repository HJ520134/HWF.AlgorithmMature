using System;
using System.Collections.Generic;
using System.Text;

namespace HWF.AlgorithmMature.QueueStack
{
    public class CloneGraphClass
    {
        public Node CloneGraph(Node node)
        {
            if (node==null) 
            {
                return new Node();
            }

            var nodeDic = new Dictionary<int, Node>();
            var queue = new Queue<Node>();
            queue.Enqueue(node);
            nodeDic.Add(node.val, new Node(node.val, new List<Node>()));
            while (queue.Count > 0)
            {
                var tempNode = queue.Dequeue();
                foreach (var item in tempNode.neighbors)
                {
                    if (!nodeDic.ContainsKey(item.val))
                    {
                        nodeDic.Add(item.val, new Node(item.val, new List<Node>()));
                        queue.Enqueue(item);
                    }

                    nodeDic[tempNode.val].neighbors.Add(nodeDic[item.val]);
                }
            }

            return nodeDic[node.val];
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
