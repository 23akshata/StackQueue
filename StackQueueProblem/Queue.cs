using StackQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Queue
    {
        private Node front;
        private Node tail;

        public Queue()
        {
            this.front = null;
            this.tail = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (tail == null)
            {
                tail = node;
                front = node;
            }
            else
            {
                node.next = tail;
                tail = node;
            }
            Console.WriteLine($"\n{data} is added in queue");
        }
        public void Display()
        {
            Node temp = tail;
            Console.WriteLine("The Stack: \n");
            while (temp != null)
            {
                Console.Write($"|{temp.data}|");
                temp = temp.next;
            }
        }


    }
}