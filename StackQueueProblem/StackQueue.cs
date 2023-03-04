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

        public void push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine(data);
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

        internal void Push(int v)
        {
            throw new NotImplementedException();
        }
    }
}