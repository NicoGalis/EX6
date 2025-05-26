using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        System.Console.WriteLine(Holiii);
        System.Console.WriteLine("hola");
        System.Console.WriteLine("canvi dos");
        Console.Write("Introdueix un valor enter: ");
        if (int.TryParse(Console.ReadLine(), out int limit))
        {
            List<int> multiples = Metodes.ComptadorMultiples(limit);
            Console.WriteLine($"Els nombres múltiples de 7 menors que {limit} són: {string.Join(", ", multiples)}");
        }
        else
        {
            Console.WriteLine("Si us plau, introdueix un nombre enter vàlid.");
        }
    }
}

//holaaaa

class Metodes
{
    public static List<int> ComptadorMultiples(int limit)
    {
        List<int> multiples = new List<int>();

        for (int i = 1; i < limit; i++)
        {
            if (i % 7 == 0)
            {
                multiples.Add(i);
            }
        }

        return multiples;
    }
}

