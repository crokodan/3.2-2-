using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Задание_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, z, k;
            Console.Clear();
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            z = 1;
            k = 0;
            while (z < n - k)
            {
                z = z + k;
                k = z - k;
                Console.Write(z + " ");
            }
            Console.ReadLine();
        }
    }
}
