using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDouble
{
    
    
        class Node
        {
            public int data;
            public Node next, prev;

            public Node(int ele)
            {
                data = ele;
                next = null;
                prev = null;
            }
        }
        class DLL
        {
            public Node head;
            public int count;
            public DLL()
            {
                head = null;
                count = 0;
            }
            public void insertbegin(int ele)
            {
                Node newnode = new Node(ele);
                if (head == null)
                    head = newnode;
                else
                {
                    newnode.next = head;
                    head.prev = newnode;
                    head = newnode;
                }
                count++;
            }
            public void insertend(int ele)
            {
                Node newnode = new Node(ele);
                if (head == null)
                    head = newnode;
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                        temp = temp.next;


                    temp.next = newnode;
                    newnode.prev = temp;
                }
                count++;
            }

            public void insertpos(int ele, int pos)
            {
                if (pos == 1)
                    insertbegin(ele);
                else if (pos == count + 1)
                    insertend(ele);
                else
                {
                    Node newnode = new Node(ele);
                    Node cn, pn;
                    pn = cn = head;
                    for (int i = 1; i < pos; i++)
                    {
                        pn = cn;
                        cn = cn.next;
                    }
                    pn.next = newnode;
                    newnode.prev = pn;
                    newnode.next = cn;
                    cn.prev = newnode;
                    count++;
                }
            }

            public void display()
            {
                if (head == null)
                    Console.WriteLine("List is empty");
                else
                {
                    Node temp = head;
                    Console.WriteLine("Elements inn list ");
                    while (temp != null)
                    {
                        Console.Write(temp.data + "\t");
                        temp = temp.next;
                    }
                    Console.WriteLine();
                }
            }
            public Node lastnode()
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;

                return temp;
            }

            public void printrev()
            {
                if (head == null)
                    Console.WriteLine("List is empty");
                else
                {
                    Node lastnd = lastnode();
                    while (lastnd != null)
                    {
                        Console.Write(lastnd.data + "\t");
                        lastnd = lastnd.prev;
                    }
                    Console.WriteLine();
                }
            }

            public int find(int ele)
            {
                int flag = -1;
                Node temp = head;
                int pos = 0;
                while (temp != null)
                {
                    pos++;
                    if (temp.data == ele)
                        return pos;
                    temp = temp.next;
                }
                return flag;
            }
            public int find(int ele, int occ)
            {
                int flag = -1, count = 0;
                Node temp = head;
                int pos = 0;
                while (temp != null)
                {
                    pos++;
                    if (temp.data == ele)
                    {
                        count++;
                        if (count == occ)
                            return pos;
                    }
                    temp = temp.next;
                }
                if (count == 0)
                    return -1;
                else
                    return -2;
            }

            public void deletebegin()
            {
                if (head == null)
                    Console.WriteLine("List is empty hence cannot delete");
                else
                {
                    Node temp = head;
                    head = head.next;
                    if (head != null)
                        head.prev = null;
                    Console.WriteLine("deleting the element = " + temp.data);
                    temp = null;
                    count--;
                }
            }
            public void deleteend()
            {
                if (head == null)
                    Console.WriteLine("List is empty hence cannot delete");
                else
                {
                    Node pn, cn;
                    cn = pn = head;
                    while (cn.next != null)
                    {
                        pn = cn;
                        cn = cn.next;
                    }
                    if (pn == cn)
                        head = null;
                    pn.next = null;
                    Console.WriteLine("deleting the element = " + cn.data);
                    cn = null;
                    count--;
                }
            }

            public void deletepos(int pos)
            {
                if (pos == 1)
                    deletebegin();
                else if (pos == count)
                    deleteend();
                else
                {
                    Node pn, cn;
                    pn = cn = head;
                    for (int i = 1; i < pos; i++)
                    {
                        pn = cn;
                        cn = cn.next;
                    }
                    pn.next = cn.next;
                    cn.next.prev = pn;
                    Console.WriteLine("deleting the element = " + cn.data);
                    cn = null;
                    count--;
                }
            }
        }
    }


