using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree(50);
            bt.head.Left = new Node(20);
            bt.head.Left.Left = new Node(5);
            bt.head.Left.Right = new Node(25);
            bt.head.Right = new Node(70);
            bt.PrintTree();
            Console.WriteLine("*************************************");
            bt.add(30);
            bt.add(85);
            bt.add(17);
            bt.PrintTree();
            Console.WriteLine("*************************************");
            Console.WriteLine(bt.GetMax());
            Console.WriteLine(bt.GetMax2());
            Console.WriteLine(bt.GetMin());
            Console.WriteLine(bt.Find(30).Value);
            Console.WriteLine(bt.Find2(25).Value);
            Console.WriteLine(bt.Delete(700));
            Console.WriteLine(bt.Delete(30));
            bt.PrintTree();
            Console.WriteLine("NOTICE!!!!! the value : '30' has been deleted !");
            Console.WriteLine(bt.Delete(20));
            bt.PrintTree();
            Console.WriteLine("NOTICE!!!!! the value : '20' CANOT be deleted !");

        }
    }
    class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }
        public Node(int value)
        {
            Value = value;
        }
    }

    class BinaryTree
    {
        public Node head;
        public BinaryTree(int value)
        {
            head = new Node(value);
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public void PrintTree()
        {
            Print(head);
            Console.WriteLine();
        }
        private void Print(Node node)
        {
            if (node.Left != null)
            {
                Print(node.Left);
            }
            Console.Write(node.Value + ", ");
            if (node.Right != null)
            {
                Print(node.Right);
            }
        }
        public void add(int value)
        {
            if (IsEmpty())
                head = new Node(value);
            else
                RecAdd(head, value);
        }
        private void RecAdd(Node temp, int value)
        {
            if (value < temp.Value)
            {
                if (temp.Left == null)
                {
                    temp.Left = new Node(value);
                }
                else
                    RecAdd(temp.Left, value);
            }
            else
            {
                if (temp.Right == null)
                {
                    temp.Right = new Node(value);
                }
                else
                    RecAdd(temp.Right, value);
            }
        }
        public int GetMax()
        {
            if (head == null)
            {
                return 0;
            }
            return GetMaxRec(head);
        }
        private int GetMaxRec(Node node)
        {
            if (node.Right == null)
                return node.Value;
            return GetMaxRec(node.Right);

        }
        public int GetMax2()
        {
            if (head == null)
                return 0;
            Node temp = head;
            for (; temp.Right != null; temp = temp.Right) { }
            return temp.Value;
        }
        public int GetMin()
        {
            if (head == null)
                return 0;
            Node temp = head;
            for (; temp.Left != null; temp = temp.Left) { }
            return temp.Value;
        }
        public Node Find(int valueToFind)
        {
            Node temp = head;
            while (temp != null)
            {
                if (valueToFind == temp.Value)
                    return temp;
                else if (temp.Value > valueToFind)
                    temp = temp.Left;
                else
                    temp = temp.Right;
            }
            return null;
        }
        public Node Find2(int valueToFind)
        {
            return Find(head, valueToFind);
        }
        private Node Find(Node temp, int valueToFind)
        {
            if (temp != null)
            {
                if (temp.Value == valueToFind)
                    return temp;
                else if (valueToFind < temp.Value)
                    return Find(temp.Left, valueToFind);
                else
                    return Find(temp.Right, valueToFind);
            }
            return null;
        }
        public bool Delete(int valueToDelete)
        {
            if (Find(valueToDelete) == null)
            {
                Console.WriteLine("there is no match value in this tree !");
                return false;
            }
            Node temp = head;
            if (head != null && head.Value == valueToDelete)
            {
                if (head.Left == null && head.Right == null)
                {
                    head = null;
                    return true;
                }
                return false;
            }
            while (temp != null)
            {
                if (temp.Left != null && temp.Left.Value == valueToDelete)
                {
                    if (temp.Left.Left == null && temp.Left.Right == null)
                    {
                        temp.Left = null;
                        return true;
                    }
                    else return false;
                }
                else if (temp.Right != null && temp.Right.Value == valueToDelete)
                {
                    if (temp.Right.Left == null && temp.Right.Right == null)
                    {
                        temp.Right = null;
                        return true;
                    }
                    else return false;
                }
                else if (valueToDelete < temp.Value)
                    temp = temp.Left;
                else// if (temp.Value < valueToDelete)
                    temp = temp.Right;
            }
            return false;
        }

    }
}

