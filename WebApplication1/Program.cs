using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce un año:");
        int inputYear = int.Parse(Console.ReadLine());
        Console.WriteLine(EsBisiesto(inputYear) ? "Es un año bisiesto" : "No es un año bisiesto");
    }

    static bool EsBisiesto(int year) =>
        (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
}
