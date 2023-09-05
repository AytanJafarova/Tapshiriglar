// 5. Dictionary yaradın, key-i GUİD və value-su List<User> obyekti olsun (Id, name, surname, age). Daha sonra dictionary-ə 10 element əlavə edin və sonda dictionary-də yaşları eyni olan userləri eyni strukturlu başqa bir dictionary-ə yığın, hansı bu bu dictionary-nin key-i yaş, value-su isə həmən yaşdakı userlər olacaq.
using System;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Dictionary with Guid keys and List<User> values
        Dictionary<Guid, List<User>> userDictionary = new Dictionary<Guid, List<User>>();

        // Add 10 elements to the dictionary
        for (int i = 0; i < 10; i++)
        {
            Guid key = Guid.NewGuid();

            List<User> users = new List<User>
        {
            new User { Id = 1, Name = "Aytan", Surname = "Jafarova", Age = 20 },
            new User { Id = 2, Name = "Aysu", Surname = "Kazimova", Age = 22 },
            new User { Id = 3, Name = "Nurlan", Surname = "Nazimli", Age = 21 },
            new User { Id = 4, Name = "Ilkin", Surname = "Mammadov", Age = 27 },
            new User { Id = 5, Name = "Murad", Surname = "Qadirov", Age = 21 },
            new User { Id = 6, Name = "Fidan", Surname = "Xanlarova", Age = 21 },
            new User { Id = 7, Name = "Shafa", Surname = "Samadli", Age = 20 },
            new User { Id = 8, Name = "Fuad", Surname = "Mahmudov", Age = 20 },
            new User { Id = 9, Name = "Saleh", Surname = "Abbas", Age = 25 },
            new User { Id = 10, Name = "Tebriz", Surname = "Hesenli", Age = 26 }

        };

            // Check if the age is already a key in the dictionary
            if (userDictionary.ContainsKey(key))
            {
                userDictionary[key].AddRange(userList);
            }
            else
            {
                userDictionary[key] = userList;
            }
        }

        // Create a Dictionary to collect users with the same age
        Dictionary<int, List<User>> usersByAgeDictionary = new Dictionary<int, List<User>>();

        // Iterate through the users in the original dictionary and group them by age
        foreach (var kvp in userDictionary)
        {
            foreach (var user in kvp.Value)
            {
                if (usersByAgeDictionary.ContainsKey(user.Age))
                {
                    usersByAgeDictionary[user.Age].Add(user);
                }
                else
                {
                    usersByAgeDictionary[user.Age] = new List<User> { user };
                }
            }
        }

        // Print the users by age
        foreach (var kvp in usersByAgeDictionary)
        {
            Console.WriteLine($"Age: {kvp.Key}");
            foreach (var user in kvp.Value)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Surname: {user.Surname}");
            }
            Console.WriteLine();
        }
    }
}