using System;

namespace fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + " " + n2 + " ");
            for(int i=2;i<n;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
