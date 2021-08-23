using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter a no");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of" +"n"+ "is:" + fact);
        }
    }
}
