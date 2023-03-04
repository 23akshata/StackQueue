using StackQueue;
using System;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node top;
        public Stack()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
                node.next = null;
            else
                node.next = top;
            top = node;
            Console.WriteLine($"{data} Has been added");
        }
        public void Display()
        {
            Node temp = top;
            Console.WriteLine("The Stack: \n");
            while (temp != null)
            {
                Console.WriteLine($"|{temp.data}|");
                Console.WriteLine("---");
                temp = temp.next;
            }
        }
        public void Pop()
        {
            if (top != null)
            {
                Console.WriteLine($"{top.data}");
                top = top.next;
            }
            Display();
        }
        public int Peak()      //Displaying the topmost element in the stack.
        {
            if (top == null)
            {
                Console.WriteLine("List is Empty");
                return 0;
            }
            else
            {
                Console.WriteLine("Top most element is : " + top.data);
                return top.data;
            }
        }
    }
}