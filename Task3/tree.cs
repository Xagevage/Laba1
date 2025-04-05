using System;
using System.Collections.Generic;

namespace Task_3.Tree
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }

        public void PrintTree()
        {
            PrintRecursive(this, "");
        }

        private void PrintRecursive(TreeNode<T> node, string indent)
        {
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintRecursive(child, indent + "  ");
            }
        }
    }
}
