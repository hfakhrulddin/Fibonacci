using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the required Fibonacci seq !!!");
            int Input = Int32 .Parse(Console.ReadLine());

            for (int i = 0; i < Input; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            Console.ReadLine();
        }
    }
}
