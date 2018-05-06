using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    class Program
    {
        
        public static Random r = new Random();

        public static int[] RandomArray()
        {
            int[] arr = new int[10];
            // int min = 25;
            // int max = 5;
            int sum = 0;
            for (int i=0; i<10; i++)
            {
                int x = r.Next(5,26);
                // min = x < min ? x : min;
                // max = x > max ? x : max;
                sum += x;
                arr[i] = x;
            }
            // Console.WriteLine($"min: {min}, max: {max}, sum: {sum}");
            Array.Sort(arr);
            Console.WriteLine($"min: {arr[0]}, max: {arr[9]}, sum: {sum}");
            return arr;
        }

        public static bool CoinToss()
        {
            return r.NextDouble() > 0.5;
        }

        public static double TossMultipleCoins(int num)
        {
            double heads = 0.0;
            int count = 0;
            while (count++ < num)
            {
               heads = CoinToss() ? heads + 1 : heads;
            }
            return heads/num;
        }

        public static List<string> Names()
        {
            // Create an array with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> names = new List<string> {
                "Todd", 
                "Tiffany", 
                "Charlie", 
                "Geneva", 
                "Sydney"
            };

            // Shuffle the array and print the values in the new order
            var shuffledNames = names.OrderBy(a => Guid.NewGuid()).ToList();

            // Return an array that only includes names longer than 5 characters
            var longerThan5 = shuffledNames.Where(a => a.Length > 5).ToList();

            return longerThan5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", RandomArray()));
            Console.WriteLine(TossMultipleCoins(100));
            Console.WriteLine(string.Join(", ", Names()));
        }
        
    }
}
