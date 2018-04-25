using System;
using DbConnection;
using System.Collections.Generic;

namespace crud
{
    class Program
    {

        public static void PrintUsers()
        {
            var users = new List<Dictionary<string, object>>();
            users = DbConnector.Query("SELECT * FROM users;");
            foreach (Dictionary<string, object> user in users)
            {
                Console.WriteLine($"ID: {user["id"]},\nFirst Name: {user["first_name"]},\nLast Name: {user["last_name"]},\nFavorite Number: {user["favorite_num"]}\n");
            }
        }

        public static void CreateUser()
        {
            Console.WriteLine("What is the first name?");
            string first = Console.ReadLine();
            Console.WriteLine("What is the last name?");
            string last = Console.ReadLine();
            Console.WriteLine("What is the favorite number?");
            string num = Console.ReadLine();
            DbConnector.Execute($"INSERT INTO users (first_name, last_name, favorite_num) VALUES ('{first}', '{last}', '{num}');");
        }

        public static void UpdateUser()
        {
            Console.WriteLine("What is the ID of the user you would like to update?");
            string id = Console.ReadLine();
            var user = new List<Dictionary<string, object>>();
            user = DbConnector.Query($"SELECT * FROM users WHERE id = {id};");
            if (user.Count < 1)
            {
                Console.WriteLine($"There is no user with the id `{id}`");
            }
            else
            {
                Console.WriteLine($"Enter a new First Name or nothing to keep previous  ({user[0]["first_name"]})");
                string first = Console.ReadLine();
                first = (first.Length > 0) ? first : (string)user[0]["first_name"];
                Console.WriteLine($"Enter a new Last Name or nothing to keep previous ({user[0]["last_name"]})");
                string last = Console.ReadLine();
                last = (last.Length > 0) ? last : (string)user[0]["last_name"];
                Console.WriteLine($"Enter a new Favorite number or nothing to keep previous ({user[0]["favorite_num"]})");
                string num = Console.ReadLine();
                num = (num.Length > 0) ? num : user[0]["favorite_num"].ToString();
                DbConnector.Execute($"UPDATE users SET first_name = '{first}', last_name = '{last}', favorite_num = '{num}' WHERE id = {id}");
            }
        }

        public static void DeleteUser()
        {
            Console.WriteLine("What is the ID of the user you would like to delete?");
            string id = Console.ReadLine();
            var user = new List<Dictionary<string, object>>();
            user = DbConnector.Query($"SELECT * FROM users WHERE id = {id};");
            if (user.Count < 1)
            {
                Console.WriteLine($"There is no user with the id `{id}`");
                return;
            }
            user = DbConnector.Query($"SELECT * FROM users WHERE id = {id};");
            Console.WriteLine($"Are you sure you want to delete {user[0]["first_name"]} {user[0]["last_name"]}? Y/N");
            string res = Console.ReadLine();
            if (res == "y" || res == "Y")
            {
                DbConnector.Execute($"DELETE FROM users WHERE id = {id}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to users!");
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Please select what you would like to do?");
                Console.WriteLine("C - Create a user | R - View all users | U - Update a user | D - Delete a user | X - Exit");
                string selection = Console.ReadLine();
                if (selection == "C" || selection == "c")
                {
                    CreateUser();
                }
                else if (selection == "R" || selection == "r")
                {
                    PrintUsers();
                }
                else if (selection == "U" || selection == "u")
                {
                    UpdateUser();
                }
                else if (selection == "D" || selection == "d")
                {
                    DeleteUser();
                }
                else if (selection == "X" || selection == "x")
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine($"Unknown selection {selection}");
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
