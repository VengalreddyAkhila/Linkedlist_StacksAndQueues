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
        /// <summary>
        /// removing the top node and allows the next node as top
        /// </summary>
        public void pop()
        {
            if (this.top == null)
                return;
              this.top = this.top.next;
        }
        /// <summary>
        /// peek is to show top element of stack
        /// </summary>
        public void peek()
        {
            if (this.top == null)
                Console.WriteLine("stack is empty");
            else
                Console.WriteLine(this.top.data);
        }
        /// <summary>
        /// Adds the elements in queue 
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(int data)
        {
            Node node = new Node();
            node.data = data;
            if (this.top == null)
            {
                this.top = node;
                node.next = null;
            }
            else
            {
                Node temp = top;

                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"element add to Queue: {node.data}");
        }
        /// <summary>
        /// show the queue list
        /// </summary>
        public void Show()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

    }
    
}
