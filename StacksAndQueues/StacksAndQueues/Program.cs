using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node = new Node();
            node.Push(56);
            node.Push(30);
            node.Push(70);
            node.Display();
        }
    }
}
