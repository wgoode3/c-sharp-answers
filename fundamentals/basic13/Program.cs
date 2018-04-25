using System;

namespace basic13
{
    class Program
    {
        public static void print1to255()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void printOdds1to255()
        {
            for (int i = 1; i < 256; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        public static void printIntsAndSum1to255()
        {
            int sum = 0;
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine($"New number: {i}, Sum: {sum += i}");
            }
        }
        public static void iterateThroughArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void findMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
        public static void getAverage(int[] arr)
        {
            double sum = 0.0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = sum / arr.Length;
            Console.WriteLine(avg);
        }
        public static void arrayOfOdds1to255()
        {
            int[] arr = new int[128];
            for (int i = 0; i < 128; i++)
            {
                arr[i] = i * 2 + 1;
            }
            Console.WriteLine(arr);
        }
        public static void greaterThanY(int[] arr, int y)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > y)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void squareTheValues(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
            }
            iterateThroughArray(arr);
        }
        public static void removeNegatives(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            iterateThroughArray(arr);
        }
        public static void minMaxAvg(int[] arr)
        {
            double sum = arr[1];
            int min = arr[1];
            int max = arr[1];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine($"Max: {max}, Min: {min}, Avg: {sum / arr.Length}");
        }
        public static void shiftValues(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;
            iterateThroughArray(arr);
        }
        public static object[] numberToString(int[] arr)
        {
            object[] objs = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    objs[i] = arr[i];
                }
                else
                {
                    objs[i] = "Dojo";
                }
            }
            return objs;
        }
        public static void printArray(object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            // print1to255();
            // printOdds1to255();
            // printIntsAndSum1to255();
            int[] arr = { 1, -3, 0, 5, 17, -9, 8 };
            // iterateThroughArray(arr);
            // findMax(arr);
            // getAverage(arr);
            // arrayOfOdds1to255();
            // greaterThanY(arr, 3);
            // squareTheValues(arr);
            // removeNegatives(arr);
            // minMaxAvg(arr);
            // shiftValues(arr);
            printArray(numberToString(arr));
        }
    }
}
