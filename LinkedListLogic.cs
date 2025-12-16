
using System;

namespace Musafirassignment
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedListLogic
    {
        public static void Run()
        {
            Console.WriteLine("Question-3. Nth Node From End:");

            Node head = new Node(1);
            head.Next = new Node(2);
            head.Next.Next = new Node(3);
            head.Next.Next.Next = new Node(4);

            Console.WriteLine("Linked List: 1 -> 2 -> 3 -> 4");

            int n = 2;
            Console.WriteLine("N = 2");

            Console.WriteLine($"Result: {FindNthFromEnd(head, n)}");
        }

        public static int FindNthFromEnd(Node head, int n)
        {
            Node fast = head;
            Node slow = head;

            for (int i = 0; i < n; i++)
            {
                fast = fast.Next;
            }

            while (fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            return slow.Data;
        }
    }
}
