using System;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("please input a:");
            a = int.Parse(Console.ReadLine());
            int b;
            Console.Write("please input b:");
            b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;
            while(x!=y)
            {
                if (x<y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            Console.WriteLine(x);
        }
    }
}
