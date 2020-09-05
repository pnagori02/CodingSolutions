using System;
using System.Collections.Generic;

namespace ConsoleApp10
{

    public class Node
    {
        public int Data { get; set; }
        public Node NextNode { get; set; }

        public Node(Node head, int data)
        {
            this.NextNode = head;
            this.Data = data;
        }

        public Node()
        {

        }
    }

    public class MyLinkedList
    {
        private Node head;


        public void Insert(int data)
        {
            if (head == null)
            {
                head = new Node(null, data);
            }
            else
            {
                Node newNode = new Node();
                newNode.Data = data;
                newNode.NextNode = null;
                Node current = head;
                while (current.NextNode != null)
                {
                    current = current.NextNode;
                }

                current.NextNode = newNode;
            }
        }

    }

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           MyLinkedList list = new MyLinkedList();
           list.Insert(5);
           list.Insert(6);
           list.Insert(9);
           list.Insert(10);

        }
    }
}
