using System;

namespace BackJoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int i = 0; i < T/4; i++)
            {
                Console.Write("long ");
            }
            Console.WriteLine("int");            
        }
    }
}