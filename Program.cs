using System;

class Program
{
    static void Main()
    {
        Console.Write("Ile ocen chcesz wprowadzić? ");
        int liczbaOcen = Convert.ToInt32(Console.ReadLine());

        double suma = 0;

        for (int i = 1; i <= liczbaOcen; i++)
        {
            Console.Write($"Podaj ocenę {i}: ");
            double ocena = Convert.ToDouble(Console.ReadLine());

            while (ocena < 1 || ocena > 6)
            {
                Console.WriteLine("Ocena musi być w zakresie 1–6.");
                Console.Write($"Podaj ocenę {i} ponownie: ");
                ocena = Convert.ToDouble(Console.ReadLine());
            }

            suma += ocena;
        }

        double srednia = suma / liczbaOcen;
        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");
    }
}