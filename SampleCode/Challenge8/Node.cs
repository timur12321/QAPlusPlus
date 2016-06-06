using System;
using System.Globalization;

namespace Challenge8
{
    public class Node
    {
        private string _data = String.Empty;
        private Node _next = null;

        public Node(string nodeData, Node nextNode)
        {
            _data = nodeData;
            _next = nextNode;
        }

        public Node Delete()
        {
            return _next;
        }

        public void PrintAllNodes()
        {
            Console.WriteLine(_data);

            if (_next != null)
            {
                _next.PrintAllNodes();
            }
        }

        public int CountAllNodes()
        {
            if (_next == null)
            {
                return 1;
            }

            return 1 + _next.CountAllNodes();
        }
    }
}
