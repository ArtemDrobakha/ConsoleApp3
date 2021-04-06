using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        delegate int Link(int a);
        static int F3(int a)
        {
            return a % 3;
        }
        static int F7(int a)
        {
            return a % 7;
        }
        static void Main(string[] args)
        {
            int[] mas1 = { 7, 14, 21, 35, 42 };
            Link link = F3;

            for (int i = 0; i < mas1.Length; i++)
            {
                if (link(mas1[i]) == 0)
                {
                    link = F7;
                    if (link(mas1[i]) == 0)
                    {
                        Console.WriteLine(mas1[i]);
                    }
                    link = F3;
                }
            }

            Console.ReadKey();
        }
    }
}