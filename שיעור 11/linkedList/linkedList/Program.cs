using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedList list1 = new linkedList(28);
            list1.printList();
            list1.insertFirst(5);
            list1.printList();
            list1.insertFirst(23);
            list1.printList();
            list1.insertLast(12);
            list1.printList();
            list1.deleteList();
            list1.insertLast(4);
            list1.printList();
            list1.exists(4);
        }

        class node
        {
            public int value;
            public node next;
            public node(int v)
            {
                value = v;
            }
        }
        class linkedList
        {
            node head;
            public linkedList(int value)
            {
                head = new node(value);
            }
            public void insertLast(int value)
            {
                {
                    if (head == null)
                    {
                        insertFirst(value);
                        return;
                    }
                    node temp = head;
                    for (; temp.next != null; temp = temp.next) { }
                    temp.next = new node(value);
                }
            }
            public void insertFirst(int value)
            {
                node new_node = new node(value);
                new_node.next = head;
                head = new_node;
            }
            public void insertAfter(node temp, int value)
            {

            }
            public void addSorted(int valueToAdd)
            {

            }
            public void deleteList()
            {
                head = null;
            }
            public bool exists(int valueToFind)
            {
                for (node temp = head; temp != null; temp = temp.next)
                {
                    if (temp.value == valueToFind)
                        return true;
                    else
                        return false;
                }
            }
            public node findNode(int valueToFind)
            {
                for (node temp = head; temp != null; temp = temp.next)
                {
                    if (temp.value == valueToFind)
                        return temp;
                    else
                        return null;
                }
            }
            public void removeFirst()
            {

            }
            public void remove(int valueToRemove)
            {

            }
            public void printList()
            {
                for (node temp = head; temp != null; temp = temp.next)
                {
                    Console.Write(temp.value + "-->");
                }
                Console.WriteLine("NULL");
            }
        }
    }
}
