// 1.User modeli yaradın, Id, Name, Surname və Age propertyləri olsun. Daha sonra başqa class daxilində parameter olaraq List<User> qəbul edən və geriyə userlərə aid unikal yaşların siyahısını qaytaran metod yazın və metodu main metodu daxilində çağırıb nəticəni ekrana yazdırın.
using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

public class Selection
{
    public List<int> SelectAges(List<User> users)
    {

        List<int> selections = users.Select(user => user.Age).Distinct().ToList();
        return selections;
    }
}

class Program
{
    static void Main(string[] args)
    {
       
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

        Selection select = new Selection();
        List<int> selectedAges = select.SelectAges(users);

        Console.WriteLine("Unique Ages in the List are:");
        foreach (int age in selectedAges)
        {
            Console.WriteLine(age);
        }
    }
}

