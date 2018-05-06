using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create an array to hold integer values 0 through 9
            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(string.Join(", ", numbers));

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(string.Join(", ", names));

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] booleans = new bool[10];
            for (int i=0; i<10; i++)
            {
                booleans[i] = i % 2 == 0;
            }
            Console.WriteLine(string.Join(", ", booleans));

            // With the values 1-10, use code to generate a multiplication table
            for(int i=1; i<11; i++)
            {
                int[] temp = new int[10];
                for(int j=0; j<numbers.Length; j++)
                {
                    temp[j] = (numbers[j] + 1) * i;
                }
                Console.WriteLine(string.Join(", ", temp));
            }

            // Create a list of Ice Cream flavors that holds at least 5 different flavors
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Green Tea");
            flavors.Add("Mango");

            // Output the length of this list after building it
            Console.WriteLine($"There are {flavors.Count} flavors");

            // Output the third flavor in the list, then remove this value.
            Console.WriteLine($"The third flavor is {flavors[2]}");
            flavors.RemoveAt(2);

            // Output the new length of the list (Note it should just be one less~)
            Console.WriteLine($"There are now {flavors.Count} flavors");

            // Create a Dictionary that will store both string keys as well as string values
            Dictionary<string,string> orders = new Dictionary<string,string>();

            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            foreach (string name in names)
            {
                orders[name] = null;
            }

            // For each name key, select a random flavor from the flavor list above and store it as the value
            Random r = new Random();
            foreach (string name in names)
            {
                orders[name] = flavors[r.Next(4)];
            }

            // Loop through the Dictionary and print out each user's name and their associated ice cream flavor.
            foreach (KeyValuePair<string,string> entry in orders)
            {
                Console.WriteLine($"{entry.Key} ordered {entry.Value}");
            }

        }
    }
}
