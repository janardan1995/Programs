using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    //created a node 
    
    public class Node1<T>
    {
        public T data;
        public Node1<T> next;
        public Node1(T d)
        {
            this.data = d;
            this.next = null;
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            this.data = d;
            this.next = null;
        }
    }

    //my utility class is here
    class Utility<T>
    {
        Node1<T> head;
        //to print the elements of a linked list.....>
        public static void PrintLinkList(Node1<T> head)
        {
            Node1<T> n = head;
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }

        }
        //file path
        public static String FileElement(String filePath)
        {
            String text = System.IO.File.ReadAllText(filePath);
            Console.WriteLine(text);
            return text;
        }
        public static void append(T new_data, Node1<T> head)
        {
            Node1<T> new_node = new Node1<T>(new_data);

            if (head == null)
            {
                head = new Node1<T>( new_data);
                return;
            }

            new_node.next = null;


            Node1<T> last = head;
            while (last.next != null)
                last = last.next;

            /* 6. Change the next of last node */
            last.next = new_node;
            return;
        }

    }
}
