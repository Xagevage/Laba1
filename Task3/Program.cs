using System;
using Task_3.Tree;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример с использованием TreeNode для строк
            var root = new TreeNode<string>("Root");

            var child1 = new TreeNode<string>("Child 1");
            var child2 = new TreeNode<string>("Child 2");

            child1.AddChild(new TreeNode<string>("Child 1.1"));
            child1.AddChild(new TreeNode<string>("Child 1.2"));
            child2.AddChild(new TreeNode<string>("Child 2.1"));

            root.AddChild(child1);
            root.AddChild(child2);

            root.PrintTree();

            // Пример с использованием TreeNode для целых чисел
            var intRoot = new TreeNode<int>(1);

            var intChild1 = new TreeNode<int>(2);
            var intChild2 = new TreeNode<int>(3);

            intChild1.AddChild(new TreeNode<int>(4));
            intChild2.AddChild(new TreeNode<int>(5));

            intRoot.AddChild(intChild1);
            intRoot.AddChild(intChild2);

            intRoot.PrintTree();
        }
    }
}
