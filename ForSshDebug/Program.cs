using System;
using System.Threading;

namespace ForSshDebug
{
    internal class Program
    {
        private static int I;
        public static void Main(string[] args)
        {
            I = 0;
            while (true)
            {
                Console.WriteLine(I++);
                Thread.Sleep(1000);
            }
        }
    }
}