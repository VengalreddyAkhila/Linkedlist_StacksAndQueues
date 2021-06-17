using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    /// <summary>
    /// Implementing the stack by using linkedlist
    /// </summary>
    public class Node
    {
        public int data;
        public Node next;
        private Node top;

        public Node()
        {
            this.top = null;
        }
        /// <summary>
        /// push the data to top of the stack
        /// </summary>
        /// <param name="data"></param>       
        public void Push(int data)
        {
            Node node = new Node();
            node.data = data;

            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("element pushed to stack:" + data);
        }
        /// <summary>
        /// displays the stacks list
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
    
}
