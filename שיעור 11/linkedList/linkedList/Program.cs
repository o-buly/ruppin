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
            list1.insertLast(6);
            list1.printList();
            list1.insertLast(7);
            list1.printList();
            Console.WriteLine(list1.exists(4));
            Console.WriteLine(list1.exists(6));
            Console.WriteLine(list1.exists(100));
            list1.insertAfter(list1.findNode(6), 5);
            list1.printList();
            list1.removeFirst();
            list1.printList();
            list1.remove(20);
            list1.printList();
            list1.remove(5);
            list1.printList();
            Console.WriteLine("SORTED LINKLIST!!!! :");
            linkedList list2 = new linkedList(10);
            list2.addSorted(5);
            list2.addSorted(12);
            list2.addSorted(3);
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
                node curr = new node(value);
                curr.next = temp.next;
                temp.next = curr;
            }
            public void addSorted(int valueToAdd)
            {
                node NEW = new node(valueToAdd);
                node prev = null;
                node temp = head;
                while((temp!=null)&&(valueToAdd>temp.value))
                {
                    prev = temp;
                    temp = temp.next;
                }
                if(prev==null)
                {
                    NEW.next = temp;
                    head = NEW;
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
                node prev=head;
                for (node temp= head; temp != null; prev = temp, temp = temp.next)
                {
                    if (temp.value == valueToRemove)
                    {
                        prev.next = temp.next;
                        return;
                    }
                }
                Console.WriteLine("there is no such value in this linklist");

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
