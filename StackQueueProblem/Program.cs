using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Stack Program in Data Structures");
                Console.WriteLine("Please select as per the below given options :\n" +
                    "Press 1: Creating custom stack using LinkedList.\n ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        StackQueue stackObject = new StackQueue();
                        stackObject.Push(70);
                        stackObject.Push(30);
                        stackObject.Push(56);
                        stackObject.Display();
                        break;

                    case 2: //UC2 stack. Add 56 30 70 .  (peek -display top most element) (pop -removing top-most element)
                        StackQueue stackObject1 = new StackQueue();
                        stackObject1.Push(70);
                        stackObject1.Push(30);
                        stackObject1.Push(56);
                        stackObject1.Display(); //IsEmpty() internally calling Pop() and Pop() internally calling Peek().
                        Console.WriteLine("Is list is empty? " + stackObject1.isEmpty());
                        stackObject1.Display();
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
