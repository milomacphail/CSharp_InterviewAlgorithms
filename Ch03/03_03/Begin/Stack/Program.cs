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
            Stack theStack = new Stack(4);
            theStack.push("Avengers");
            theStack.push("Star Wars");
            theStack.push("Jaws");
            theStack.push("Alien");
            theStack.push("Alien 2");

            System.Console.WriteLine("============ \nThe Stack contains:\n");
            while(!theStack.isEmpty())
            {
                string movie = theStack.pop();
                System.Console.WriteLine(movie);
            }
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
            if (isEmpty())
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

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (maxSize - 1 == top);
        }
    }
}
