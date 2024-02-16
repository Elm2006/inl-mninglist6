using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,int> matvaror = new Dictionary<string,int>();
        Console.WriteLine("Vad ska du köpa för något");
        string svar = Console.ReadLine().ToLower();
        string[]vara=svar.Split(' ');
        Console.WriteLine("Vad är styckpriset på produkten");
        svar = Console.ReadLine();
        string[] pris = svar.Split(' ');
        for (int i = 0; i< vara.Length; i++)
        {
            matvaror.Add(vara[i], int.Parse(pris[i]));
        }
        Console.WriteLine("Skriv in din handlingslista");
        svar = Console.ReadLine().ToLower();
        string[] lista = svar.Split(' ');
        int sum = 0;
        for (int i = 0;i< lista.Length; i++)
        {
            sum += matvaror[lista[i]];
        }
        Console.WriteLine(sum+" kr");
    }
}