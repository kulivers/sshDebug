using System;
using System.Threading;
using Newtonsoft.Json;

namespace ForSshDebug
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        private static int I;
        public static void Main(string[] args)
        {
            I = 0;
            while (true)
            {
                var serializeObject = JsonConvert.SerializeObject(new Person(){Name = "asda", Age = 12});
                Console.WriteLine(I++);
                Thread.Sleep(1000);
            }
        }
    }
}