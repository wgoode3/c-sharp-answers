using System;

namespace sll
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL listy = new SLL();
            listy.add(1).add(2).add(3);
            int[] arr = listy.printToArray();
            Console.WriteLine(arr.Length);
            string s = "[";
            for (int i = 0; i < arr.Length; i++)
            {
                s += " " + arr[i] + ",";
            }
            s += "]";
            Console.WriteLine(s);
        }
    }
}
