using System;

class Program
{
    // Oppgave 1: Returner true hvis tallene er like
    static bool ErLike(int tall1, int tall2)
    {
        if (tall1 == tall2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Oppgave 2: Returner sum hvis ulike, produkt hvis like
    static int Beregn(int tall1, int tall2)
    {
        if (tall1 == tall2)
        {
            return tall1 * tall2;
        }
        else
        {
            return tall1 + tall2;
        }
    }

    // Oppgave 3: Returner true hvis en av tallene eller summen er 30
    static bool SjekkTrettio(int tall1, int tall2)
    {
        if (tall1 == 30 || tall2 == 30 || (tall1 + tall2) == 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ErLike(5, 5)); 
        Console.WriteLine(ErLike(5, 3)); 
        Console.WriteLine(Beregn(3, 3)); 
        Console.WriteLine(Beregn(3, 4)); 
        Console.WriteLine(SjekkTrettio(20, 10)); 
        Console.WriteLine(SjekkTrettio(5, 10)); 
    }
}