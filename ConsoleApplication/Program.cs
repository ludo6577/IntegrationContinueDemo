using System;
namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibo(5));
            Console.ReadLine();
        }
        public static int Fibo(int n)
        {
            return FiboImpl1(n);
        }
        public static int FiboImpl1(int n)
        {
            if (n < 0)
                throw new ArgumentException("Argument cannot be negative");

            if (n <= 1)
                return n;
            return FiboImpl1(n - 1) + FiboImpl1(n - 2);
        }
        /*
        public static int FiboImpl1(int n)
        {
            if (n < 0)
                throw new ArgumentException("Argument cannot be negative");

            int a = 0, b = 1, c = n;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
        */
    }
}
