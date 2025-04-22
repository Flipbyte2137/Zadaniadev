using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        string operacja = Console.ReadLine();

        double wynik;
        bool poprawnaOperacja = true;

        if (operacja == "+")
        {
            wynik = liczba1 + liczba2;
        }
        else if (operacja == "-")
        {
            wynik = liczba1 - liczba2;
        }
        else if (operacja == "*")
        {
            wynik = liczba1 * liczba2;
        }
        else if (operacja == "/")
        {
            if (liczba2 != 0)
                wynik = liczba1 / liczba2;
            else
            {
                Console.WriteLine("Błąd: nie można dzielić przez zero!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Błąd: nieprawidłowa operacja.");
            poprawnaOperacja = false;
            wynik = 0;
        }

        if (poprawnaOperacja)
            Console.WriteLine("Wynik: " + wynik);
    }
}