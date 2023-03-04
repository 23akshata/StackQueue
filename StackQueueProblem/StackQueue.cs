using StackQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackQueue
{
    public class StackQueue
    {
        public Node top;
        public StackQueue()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine(data);
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
        public void Pop()       //removing the topmost element from the stack .
        {
            if (top == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.WriteLine("Removed top most element : " + Peak());
                top = top.next;
            }
        }
        public bool isEmpty()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return true;
            }
            else
            {
                while (top != null)
                {
                    Pop();
                }
                return true;
            }
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("Stack is ");
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }
    }
}