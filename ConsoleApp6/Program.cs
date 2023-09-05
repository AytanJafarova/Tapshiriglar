// 6. 2 ölçülü array yaradın, sətir və sütun sayını console readline ilə əldə edin. daha sonra array elementlərinə 0 - 10 arası random ədədlər verin və arrayın baş və köməkçi dioqanal elementləri cəminin hasilini tapın.

using System;

public class ConsoleApp6
{
    public static void Main(string[] args)
    {
    againEnter:
        Random anyNum = new Random();
        int row = 0;
        int column = 0;


        Console.Write("Enter count of the rows: ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter count of the columns: ");
        column = Convert.ToInt32(Console.ReadLine());

        int[,] MyArray = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                MyArray[i, j] = anyNum.Next(0, 11);
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write(MyArray[i, j] + "\t");
            }
            Console.WriteLine();
        }

        if (row != column)
        {
            Console.WriteLine("It is not possible to find the diagonals based on your enterings! Please make it sure that row = column \n");
            goto againEnter;
        }
        else
        {
            // Primary diagonal sum
            int pSum = 0;
            for (int i = 0; i < row; i++)
            {
                pSum += MyArray[i, i];
            }

            // Secondary diagonal sum
            int sSum = 0;
            for (int i = 0; i < row; i++)
            {
                sSum += MyArray[i, row - 1 - i];
            }

            Console.WriteLine($"\nSum of the elements of primary diagonal is: {pSum}");
            Console.WriteLine($"\nSum of the elements of secondary diagonal is: {sSum}");
            Console.WriteLine($"\nProduct of these values is: {pSum * sSum}");

        }
    }

}