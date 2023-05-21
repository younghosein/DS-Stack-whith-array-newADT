using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Example_0
{
    class StackNewAdt0
    {
        int[] a1, a2;
        int top1, top2;
        int max;
        public StackNewAdt0(int size)
        {
            max = size;
            a1 = new int[max];
            a2 = new int[max];
            top1 = top2 = -1;
        }
        //true->1
        //false->2
        public bool isEmpty(bool ch)
        {
            if (ch == true)
            {
                return top1 == -1;
            }
            else
            {
                return top2 == -1;
            }
        }
        public bool isFull(bool ch)
        {
            if (ch == true)
            {
                return top1 == max - 1;
            }
            else
            {
                return top2 == max - 1;
            }
        }
        public void push(int n)
        {
            if (n % 2 == 0)
            {
                if (isFull(true))
                {
                    Console.WriteLine("\nStack 1 Is Full , Not Insert !");
                }
                else
                {
                    a1[++top1] = n;
                    Console.WriteLine($"{n} Is Pushed In Array1[{top1}]...");
                }
            }
            else
            {
                if (isFull(false))
                {
                    Console.WriteLine("\nStack 2 Is Full , Not Insert !");
                }
                else
                {
                    a2[++top2] = n;
                    Console.WriteLine($"{n} Is Pushed In Array2[{top2}]...");
                }
            }
        }
        public int pop(bool S)
        {
            if (S==false)
            {
                if (isEmpty(false))
                {
                    Console.WriteLine("\nStack 2 Is Empty , Not Delete !");
                    return -2;
                }
                else
                {
                    Console.WriteLine($"\n{a2[top2]} Is Poped In Array2...");
                    return a2[top2--];
                }
            }
            else
            {
                if (isEmpty(true))
                {
                    Console.WriteLine("\nStack 1 Is Empty , Not Delete !");
                    return -2;
                }
                Console.WriteLine($"\n{a1[top1]} Is Poped In Array1...");
                return a1[top1--];
            }
        }
        public void print()
        {
            Console.Write("\nArray ( Stack1 Before Stack 2 ) Is : ");
            if (!isEmpty(true))
            {
                for (int i = 0; i <= top1; i++)
                {
                    Console.Write(a1[i] + " . ");
                }
            }
            else
                Console.Write("Empty  ");
            Console.Write("->  ");
            if (!isEmpty(false))
            {
                for (int j = 0; j <= top2; j++)
                {
                    Console.Write(a2[j] + " . ");
                }
            }
            else
                Console.Write("Empty");
        }
        public int Len()
        {
            return (top1 + top2 + 2);
        }
    }
}
