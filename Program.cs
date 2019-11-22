using System;
public class HelloWorld
{
    public static void Main()
    {
        while (true) {
            Console.WriteLine("inserisci numero 1");
            if (double.TryParse(Console.ReadLine().Replace(".", ","), out double n1)) {
                string sel = "";
                do
                {
                    Console.WriteLine("Inserisci numero 2");
                    if (double.TryParse(Console.ReadLine().Replace(".", ","), out double n2))
                    {
                        Console.WriteLine("inserisci segno(+ , - , * , / )oppure 'c' per cancellare il secondo numero");
                        sel = Console.ReadLine().ToLower();
                        if (sel == "+") Console.WriteLine($"{n1} + {n2} = {n1 += n2}");
                        else if (sel == "-") Console.WriteLine($"{n1} - {n2} = {n1 -= n2}");
                        else if (sel == "*") Console.WriteLine($"{n1} * {n2} = {n1 *= n2}");
                        else if (sel == "/") Console.WriteLine($"{n1} / {n2} = {n1 /= n2}");
                    }
                } while (sel != "c");
            }
        }
    }
}