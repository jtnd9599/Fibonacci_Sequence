using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            a[0] = 0;
            a[1] = 1;
            Console.WriteLine("enter the total number of elements:");
            int n,k;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Fibonacci Sequence of" + n + " elements are:");
            if (n == 1)
                Console.WriteLine(a[0]);
            if (n == 2)
                Console.WriteLine(a[1]);
            else
            { 
                for(int i=2;i<n;i++)
                {
                    k = a[i - 2] + a[i - 1];
                    a[i] = k;    
                }
                for(int i=0;i<n;i++)
                {
                    Console.Write(a[i]);
                    if (i < n-1)
                        Console.Write("  -->  ");
                }
            }
            Console.ReadKey();

        }
    }
}
