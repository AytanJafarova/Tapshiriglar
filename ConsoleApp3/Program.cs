// 3. LinkedList yaradın və 10 dəyər əlavə edin. Daha sonra Console readline ilə int dəyər əldə edin və linkedlist daxilində bu ədəddən sonrakı ədədi ekrana yazdırın.
using System;

public class ConsoleApp3
{
    public static void Main(string[] args)
    {
        Random rand = new Random();
        LinkedList<int> linkedList = new LinkedList<int>();
        for(int i = 0; i < 10; i++)
        {
            linkedList.AddLast(rand.Next(0,11));
        }

        int userEntering = 0;
        Console.Write("Enter an integer: ");
        userEntering = Convert.ToInt32(Console.ReadLine());

        LinkedListNode<int> userSelection = linkedList.Find(userEntering);
        int value = 0;

        if (userSelection != null)
        {
            if (userSelection.Next != null)
            {
                value = userSelection.Next.Value;
                Console.WriteLine($"The next value in the linkedList is: {value}");
            }
            else
            {
                Console.WriteLine("There is not next number in the linkedlist based on your entering");
            }

        }
        else
        {
            Console.WriteLine("There is not such a value in the linkedList");
        }
       
    }
}