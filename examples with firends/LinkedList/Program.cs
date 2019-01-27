using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            node n1 = new node(7);
            Console.WriteLine(n1.value);
            Console.WriteLine(n1.next == null);
            linkedList list3 = new linkedList(1);
            list3.insertFirst(2);
            linkedList list = new linkedList(28);
            list.insertLast(3);
            list.insertLast(10);
            list.insertLast(4);
            list.insertFirst(1);
            list.insertAfter(list.findNode(10), 11);
            Console.WriteLine(list.exists(4));
            node FoundIt = list.findNode(4);
            if (FoundIt != null)
                Console.WriteLine(FoundIt.value);
            else
                Console.WriteLine("NOT FOUND !!!");
            list.printList();
            list.removeFirst();
            list.printList();
            list.remove(10);
            list.printList();
            Console.WriteLine("***********************");
            linkedList list2 = new linkedList(8);
            list2.addSorted(1);
            list2.addSorted(10);
            list2.addSorted(9);
            list2.addSorted(19);
            list2.printList();
            list2.deleteList();
            list2.addSorted(1);
            list2.printList();
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
                if (temp != null)
                {
                    node curr = new node(value);
                    curr.next = temp.next;
                    temp.next = curr;
                }
                else
                {
                    Console.WriteLine("ERROR !!!! ");
                }
            }
            public void addSorted(int valueToAdd) //10->5->12->3 (not sorted)
            {
                node NEW = new node(valueToAdd);
                node prev = null;
                node temp = head;
                while ((temp != null) && (valueToAdd > temp.value))
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (prev == null)
                {
                    insertFirst(valueToAdd);
                }
                else
                {
                    NEW.next = temp;
                    prev.next = NEW;
                }
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
                    {
                        return true;
                    }
                }
                return false;
            }
            public node findNode(int valueToFind)
            {
                for (node temp = head; temp != null; temp = temp.next)
                {
                    if (temp.value == valueToFind)
                        return temp;
                }
                return null;
            }
            public void removeFirst()
            {
                if (head != null)
                {
                    node temp = head.next;
                    head = temp;
                }
                else
                {
                    Console.WriteLine("ERROR");
                    return;
                }
            }
            public void remove(int valueToRemove)
            {
                if (head == null)
                {
                    return;
                }
                if (head.value == valueToRemove)
                {
                    removeFirst();
                }
                else if (head != null)
                {
                    node prev = head;
                    for (node temp = head; temp != null; prev = temp, temp = temp.next)
                    {
                        if (temp.value == valueToRemove)
                        {
                            prev.next = temp.next;
                            return;
                        }
                    }
                    Console.WriteLine("there is no such value in this linklist");
                }
                else
                {
                    Console.WriteLine("NULL !!!!!");
                }
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
