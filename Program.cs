﻿namespace Cronomento;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo desejar contar?");

        string data = Console.ReadLine().ToLower().Trim();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));

        int multiplier = 1;
        if (type == 'm')
            multiplier = 60;

        if (time == 0)
            Environment.Exit(0);

        PreStart(time * multiplier);
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Preparar...");
        Thread.Sleep(1000);
        Console.WriteLine("Apontar...");
        Thread.Sleep(1000);
        Console.WriteLine("Já...");
        Thread.Sleep(1000);

        Start(time);

    }

    static void Start(int time)
    {
        int currentTime = 0;

        while(currentTime != time)
        {
            Console.Clear();

            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Cronometro finalizado");
        Thread.Sleep(1000);
    }
}