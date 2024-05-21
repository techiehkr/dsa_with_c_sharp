using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class Stack<T>
    {
        private T[] array;
        private int top;
        private int capacity;

        public Stack(int size)
        {
            capacity = size;
            array = new T[capacity];
            top =-1;
        }
        public void Push(T item)
        {
            if (top == capacity - 1)
            {
                Console.WriteLine("Stak Overflow");
                return;
            }
            array[++top] = item;
        }

        public T pop()
        {
            if (top == -1)
            {
                Console.WriteLine("stack underflow");
                return default(T);
            }
            return array[top--];
        }

        public T Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return default(T);
            }
            return array[top];
        }
        public bool isEmpty()
        {
            return top == -1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //  LinkedList<string> a = new LinkedList<string>();
            Stack<int> stack = new Stack<int>(5);

            stack.Push(1);
         
            Console.WriteLine(
            stack.Peek());
            stack.pop();
            Console.ReadLine();
        }
    }
}
