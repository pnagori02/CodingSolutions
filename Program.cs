using System;

namespace Tree
{
    public class Node
    {
        int item;
        Node left;
        Node right;

        public int Item { get => item; set => item = value; }
        internal Node Left { get => left; set => left = value; }
        internal Node Right { get => right; set => right = value; }

        public Node (int item)
        {
            this.Item = item;
            this.Left = null;
            this.Right = null;
        }

        public Node ()
        {

        }
    }

    public class Tree
    {

        public Node AddNode(int item)
        {

            Node newNode = new Node(item);
            return newNode;
        }

        public void Insert(Node root, int item)
        {
            Node element = new Node();
            element.Item = item;
            element.Left = null;
            element.Right = null;
            Node temp = root;
            if (temp == null)
            {
                root = temp ;
            }
            else
            {
                if(item < temp.Item)
                {
                    if (temp.Left == null)
                        root.Left = element;
                    else
                        Insert(root.Left, item);
                }
                else
                {
                    if (temp.Right == null)
                        root.Right = element;
                    else
                        Insert(root.Right, item);
                }
            }
        }

        public void PrintTree(Node root)
        {
            Node temp = root;
            if(temp == null)
            {
                return;
            }
            else
            {
                PrintTree(root.Left);
                Console.WriteLine(root.Item);
                PrintTree(root.Right);
            }
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Tree bst = new Tree();
            Node root = bst.AddNode(5);
            bst.Insert(root, 10);
            bst.PrintTree(root);
            Console.WriteLine("Hello World!");
        }
    }
}
