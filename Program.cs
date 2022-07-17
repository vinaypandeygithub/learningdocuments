using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User Choose From Below Options");
            Console.WriteLine("1.Add User");
            Console.WriteLine("2.Display All Users");
            string userOption = Console.ReadLine();
            List<User> listOfUsers = new List<User>();
            while(userOption!="exit")
            {
                if (userOption == "1")
                {
                    User user = new User();
                    Console.WriteLine("First Name");
                    user.FirstName = Console.ReadLine();

                    Console.WriteLine("Last Name");
                    user.LastName = Console.ReadLine();

                    user.Address = new Address();

                    Console.WriteLine("Address Line 1");                    
                    user.Address.AddressLine1 = Console.ReadLine();

                    Console.WriteLine("Address Line 2");                    
                    user.Address.AddressLine2 = Console.ReadLine();

                    Console.WriteLine("Address Line 3");
                    user.Address.AddressLine3 = Console.ReadLine();

                    listOfUsers.Add(user);
                }
                else if (userOption == "2")
                {
                    foreach (var user in listOfUsers)
                    {
                        Console.WriteLine($"{user.FirstName} {user.LastName} lives at {user.Address}");
                    }
                
                }

                Console.WriteLine("1.Add User");
                Console.WriteLine("2.Display All Users");
                Console.WriteLine("exit to end");
                userOption = Console.ReadLine();
            }

        }
    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string TypeOfAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
    }
}
