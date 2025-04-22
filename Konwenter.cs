using System;

class Program
{
    static void Main()
    {
        Console.Write("Wybierz kierunek konwersji (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): ");
        string kierunek = Console.ReadLine().ToUpper();

        if (kierunek == "C")
        {
            Console.Write("Podaj temperaturę w stopniach Celsjusza: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine($"{c}°C = {f}°F");
        }
        else if (kierunek == "F")
        {
            Console.Write("Podaj temperaturę w stopniach Fahrenheita: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) / 1.8;
            Console.WriteLine($"{f}°F = {c}°C");
        }
        else
        {
            Console.WriteLine("Błąd: nieprawidłowy wybór.");
        }
    }
}