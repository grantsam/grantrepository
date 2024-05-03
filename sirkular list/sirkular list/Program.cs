using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace sirkular_list
{
    public class Node
    {
        public int Data;
        public Node next;
        public Node prev;

        public Node(int data)
        {
            Data = data;
            next = null;
            prev = null;
        }
    }
    public class doublelinkedlist
    { 
    private Node head;
    private Node tail;

    public doublelinkedlist()
    {
        head = null;
        tail = null;
    }

    public void insertatbegining(int data)
        {
            Node newnode = new Node(data);
            if(head == null)
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                newnode.next = head;
                head.prev = newnode;
                head = newnode;
            }
        }

        public void Display()
        {
            Node current = head;
            Console.Write("isi list : ");
            while(current != null)
            {
                Console.Write(current.Data + " ");
                current = current.next;
            }
            Console.WriteLine();

        }



    }
    class program
    {
        static void Main()
        {
            doublelinkedlist dll = new doublelinkedlist();

            dll.insertatbegining(5);
            dll.insertatbegining(4);
            dll.insertatbegining(3);
            dll.insertatbegining(2);
            dll.insertatbegining(1);

            dll.Display();
            Console.ReadLine(); 
        }
    }
}
