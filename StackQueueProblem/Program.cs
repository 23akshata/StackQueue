using System;
using System;
namespace StacksAndQueues
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Queue queue = new Queue();
            while (true)
            {
                Console.WriteLine("\nOptions: \n1.Stack Push\n2.Stack Pop\n3.Stack Peak\n4.Display stack\n5.Enqueue\n7.Display Queue");
                Console.Write("Enter a choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        break;

                    case 2:
                        stack.Pop();
                        break;

                    case 3:
                        stack.Peak();
                        break;

                    case 4:
                        stack.Display();
                        break;

                    case 5:
                        queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        break;

                    case 8:
                        queue.Display();
                        break;
                    default:

                        stack.Display();
                        break;

                }

            }


            stack.Pop();
            Console.ReadKey();
        }
    }
}
