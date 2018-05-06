using System;

namespace fundamentals
{
    class Program
    {
        static void Print1to255()
        {
            for (int i=1; i<256; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void DivisibleBy3And5ButNotBoth(int n)
        {
            for (int i=1; i<n; i++)
            {
                if (i % 15 != 0 && (i % 5 == 0 || i % 3 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void FizzBuzz(int n)
        {
            for (int i=1; i<n; i++)
            {
                string temp = ""; 
                if (i % 3 == 0)
                {
                    temp += "Fizz";
                }
                if (i % 5 == 0)
                {
                    temp += "Buzz";
                }
                if (temp.Length == 0)
                {
                    temp += i;
                }
                Console.WriteLine(temp);
            }
        }

        static bool MultipleOfThree(int i)
        {
            if (i < 10)
            {
                return i == 0 || i == 3 || i == 6 || i == 9;
            }
            string num = i.ToString();
            int x = 0;
            for (i=0; i<num.Length; i++)
            {
                x += int.Parse(num[i].ToString());
            }
            return MultipleOfThree(x);
        }

        static bool MultipleOfFive(int i)
        {
            return i.ToString().EndsWith("0") || i.ToString().EndsWith("5");
        }

        static void FizzBuzz2(int n)
        {
            for (int i=1; i<n; i++)
            {
                string temp = ""; 
                if (MultipleOfThree(i))
                {
                    temp += "Fizz";
                }
                if (MultipleOfFive(i))
                {
                    temp += "Buzz";
                }
                if (temp.Length == 0)
                {
                    temp += i;
                }
                Console.WriteLine(temp);
            }
        }

        static void FizzBuzz3(int n)
        {
            Random r = new Random();
            for (int i=1; i<n; i++)
            {
                int x = r.Next(100);
                string temp = ""; 
                if (x % 3 == 0)
                {
                    temp += "Fizz";
                }
                if (x % 5 == 0)
                {
                    temp += "Buzz";
                }
                if (temp.Length == 0)
                {
                    temp += x;
                }
                Console.WriteLine(temp);
            }
        }

        static void Main(string[] args)
        {
            // Print1to255();
            // DivisibleBy3And5ButNotBoth(100);
            // FizzBuzz(100);
            // FizzBuzz2(100);
            FizzBuzz3(10);
        }
    }
}
