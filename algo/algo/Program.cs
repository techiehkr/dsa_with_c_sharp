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
    class Node
    {
        public int Data { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int data)
        {
            Data = data;
            left = null;
            right = null;
        }
    }
    
    class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;           
        }

        public void Insert(int data)
        {
            Root = InsertRec(Root, data);
        }
        public void InOrderTraversal()
        {
            InOrderRec(Root);
        }
        public void preOrderTraversal()
        {
            PreOrederRec(Root);
        }
        public void postOrderTraversal()
        {
            PostOrderRec(Root);
        }
        public Node Search(int Data)
        {
            return SearchRec(Root, Data);
        }
        //functions
        private void InOrderRec(Node root)
        {
            if (root != null)
            {
                InOrderRec(root.left);
                Console.WriteLine(root.Data);
                InOrderRec(root.right);
            }
        }
        private void PreOrederRec(Node root)
        {
            if (root != null)
            {
               
                Console.WriteLine(root.Data);
                PreOrederRec(root.left);
                PreOrederRec(root.right);

            }
        }
        private void PostOrderRec(Node root)
        {
            if (root != null)
            {
                PostOrderRec(root.left);
                PostOrderRec(root.right);
                Console.WriteLine(root.Data);
            }
        }
        private Node InsertRec(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }
            if (data < root.Data)
            {
                root.left = InsertRec(root.left, data);
            }
            else if (data > root.Data)
            {
                root.right = InsertRec(root.left, data);
            }
            return root;
        }
        private Node SearchRec(Node root, int data)
        {
            if (root ==null || root.Data==data) {
                return root;
                    }
            if (root.Data > data)
            {
             return SearchRec(root.left, data);
            }
            else{
              return  SearchRec(root.right, data);
            }
          
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //  LinkedList<string> a = new LinkedList<string>();
            Stack<int> stack = new Stack<int>(5);
            BinaryTree tree = new BinaryTree();
            tree.Insert(1);
            tree.Insert(78);
            tree.Insert(8);
            tree.Insert(-1);
            tree.Insert(0);

            tree.InOrderTraversal();
            Console.WriteLine("pre");
            tree.preOrderTraversal();
            Console.WriteLine("post");
            tree.postOrderTraversal();
            Console.WriteLine();
            Console.WriteLine("search");
            Node a = tree.Search(1);
            if (a != null){
                Console.WriteLine($"the searched data is {a.Data} found");
            }
            else
            {
                Console.WriteLine("Search is not Found");
            }


            Console.WriteLine("search");

            stack.Push(1);
         
            Console.WriteLine(
            stack.Peek());
            stack.pop();
            Console.ReadLine();
        }
    }
}
