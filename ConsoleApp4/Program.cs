// 4. OOP principlərinə aid real nümunələr implement edin.

using System;

public class ConsoleApp4
{

    public static void Main(string[] args)
    {
        // Inheritance
        Teacher teacher  = new Teacher();
        teacher.communication();


        // Encapsulation implementation

        Student student = new Student("Aytan","Jafarova", 123456);

        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Surname: {student.Surname}");
        Console.WriteLine($"Identity: {student.Identity}");

    }
}
public class Person
{ 
    public void communication()
    {
        Console.WriteLine("Can communicate via speaking");
    }
}
public class Teacher:Person
{
}

// Polymorphism
public class Shapes
{
    public virtual void Perimeter()
    {
        Console.WriteLine("Perimeter is calculated by finding the sum of all the sides");
    }
}
public class Square:Shapes
{
    public override void Perimeter()
    {
        Console.WriteLine("The perimeter of a square is calculated by adding the lengths of all four sides");
    }
}

public class Rectangle:Shapes
{
    public override void Perimeter()
    {
        Console.WriteLine("The perimeter is calculated by adding the lengths of 2 different sides and then multiplying the sum by 2");
    }
}

// Abstraction

// We can not make Dog and Cat classes public. Because there will appear an error that will indicate base class is less accessible than derived class
abstract class Animal
{
    public abstract void makeVoice();
}

 class Dog : Animal
{
    public override void makeVoice()
    {
        Console.WriteLine("Makes such voice: Woof");
    }
}

 class Cat : Animal
{
    public override void makeVoice()
    {
        Console.WriteLine("Makes such voice: Meow");
    }
}

// Encapsulation


class Student
{
    private int identity;

    public int Identity
    {
        get
        {
            return identity;
        }
        set
        {
            identity = value;
        }
    }

    public Student(string name, string surname, int identity)
    {
        Name = name;
        Surname = surname;
        Identity = identity; 
    }

    public string Name { get; set; }
    public string Surname { get; set; }


    // Go back to the Main functoin for checking implementation
}

