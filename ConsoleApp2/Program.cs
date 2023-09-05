using System;

public class ConsoleApp2
{
    //  2. Metod yazın, metod istənilən sayda int qəbul edə bilər və qəbul etdiyi ədədlərin cəmini return edəcək. Metodu çağırın və nəticəni ekrana yazdırın.


    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Mono World");
        Console.WriteLine(SumFunc(1, 2, 3, 4, 5, 6, 7, 8, 9));
    }
    public static int SumFunc(params int[] numberList)
    {
        int sum = 0;
        foreach (int number in numberList)
        {
            sum += number;
        }
        return sum;
    }

    }