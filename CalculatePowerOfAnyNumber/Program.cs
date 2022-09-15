﻿public class RecExercise15
{
    public static void Main()
    {
        int bNum, pwr;
        int result;
        Console.Write("\n\n Recursion : Calculate power of any number :\n");
        Console.Write("------------------------------------------------\n");

        Console.Write(" Input the base  value: ");
        bNum = Convert.ToInt32(Console.ReadLine());

        Console.Write(" Input the exponent: ");
        pwr = Convert.ToInt32(Console.ReadLine());

        result = CalculateOfPower(bNum, pwr);

        Console.Write(" The value of {0} to the power of {1} is : {2} \n\n", bNum, pwr, result);
    }

    public static int CalculateOfPower(int x, int y)
    {
        if (y == 0)
            return 1;
        else
            return x * CalculateOfPower(x, y - 1);
    }
}