using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {


        class Stack
        {
            public int[] arr;
            public int top;
            public int capacity;

            // Creating a stack
            public Stack(int size)
            {
                arr = new int[size];
                capacity = size;
                top = -1;
            }

        }
            public class ST
            {
                Stack sk;

                /*
                public ST()
                {
                    Stack sk = null;
                }*/

                

                public ST(int size)
                {
                    sk= new Stack(size);
                }
                // Add elements into stack
                public void push(int x)
                {
                    if (sk.top+1 <= sk.capacity-1)
                    {
                        Console.WriteLine("Inserting " + x);
                        sk.arr[++sk.top] = x;
                    }
                  
                    else
                    {
                        Console.WriteLine("Stack is Full");
                    }
                }

                // Show Last Elemant
                public void peek()
                {
                    if (sk.top == -1)
                    {
                        Console.WriteLine("STACK EMPTY");

                    }
                    Console.WriteLine(sk.arr[sk.top]);
                }


                // Remove element from stack
                public void pop()
                {
                    if (sk.top == -1)
                    {
                        Console.WriteLine("STACK EMPTY");

                    }
                    --sk.top;
                }



                public void printStack()
                {
                    for (int i = 0; i <= sk.top; i++)
                    {
                        Console.WriteLine(sk.arr[i]);
                    }
                }


                public bool isEmpty()
                {
                    return (sk.top == -1) ? true : false;
                }

                public bool isFull()
                {
                    return (++sk.top == sk.capacity) ? true : false;
                }

                public int Search(int x)
                {
                    int a = 0;
                    while (a <= sk.top)
                    {
                        if (sk.arr[a] == x)
                            return a;

                        a++;

                    }

                    return -1;
                }

                int noOfElements()
                {
                    return sk.top+1;
                }
            }


            static void Main(string[] args)
            {
                ST stk = new ST(15);

                stk.push(5);
                stk.push(7);
                stk.push(3);
                stk.push(1);
                stk.push(8);
                stk.push(9);


                stk.printStack();

                

                
                stk.pop();

                stk.printStack();

                stk.peek();

                Console.WriteLine($"Element found at index {stk.Search(3)}");

                Console.ReadLine();

            }
        
    }
}