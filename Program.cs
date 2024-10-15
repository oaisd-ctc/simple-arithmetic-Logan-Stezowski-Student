using System;

public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide 1 number to perform the addition operation");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x + " ...got it. Provide a number to add to " + x + ".");
        int y = Convert.ToInt32(Console.ReadLine());
        int answer = x + y;
        Console.WriteLine(y + ", alright! That's easy.  " + x + " + " + y + " is " + answer + ".");

        Console.WriteLine("Provide 1 number to perform the subtraction operation");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a + " ...got it. Provide a number to subtract from " + a + ".");
        int b = Convert.ToInt32(Console.ReadLine());
        int answer2 = a - b;
        Console.WriteLine(b + ", alright! That's easy.  " + a + " - " + b + " is " + answer2 + ".");

        Console.WriteLine("Provide 1 number to perform the multiplication operation");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(c + " ...got it. Provide a number to multiply by " + c + ".");
        int d = Convert.ToInt32(Console.ReadLine());
        int answer3 = c * d;
        Console.WriteLine(d + ", alright! That's easy.  " + c + " * " + d + " is " + answer3 + ".");

         Console.WriteLine("Provide 1 number to perform the division operation");
        int e = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(e + " ...got it. Provide a number to divide by " + e + ".");
        int f = Convert.ToInt32(Console.ReadLine());
        int answer4 = e/f;
        Console.WriteLine(f + ", alright! That's easy.  " + e + " / " + f + " is " + answer4 + ".");

        Console.WriteLine("Provide 1 decimal to perform the division operation");
        double g = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(g + " ...got it. Provide a decimal to divide from " + g + ".");
        double h =  Convert.ToDouble(Console.ReadLine());
        double answer5 = g / h;
        Console.WriteLine(h + ", alright! That's easy.  " + g + " / " + h + " is " + answer5 + ".");

         Console.WriteLine("Provide 1 number to perform the Modulus operation");
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(i + " ...got it. Provide another number.");
        int j = Convert.ToInt32(Console.ReadLine());
        int answer6 = i % j;
        Console.WriteLine(j + ", alright! That's easy.  " + i + " - " + j + " is " + answer6 + ".");
    }
}
