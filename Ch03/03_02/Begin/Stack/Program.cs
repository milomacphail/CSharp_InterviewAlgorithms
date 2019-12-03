using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
        }
    }

    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void push(string m)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }

        public string pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }

        public string peek()
        {
            return stackArray[top];
        }

        private bool isEmpty()
        {
            return (top == -1);
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
