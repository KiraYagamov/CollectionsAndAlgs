using System;

namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("10");
            list.Add("20");
            list.Add("30");
            list.Add("Пицца");
            Console.WriteLine(list.Get(3));
        }
    }
}