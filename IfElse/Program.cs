﻿namespace IfElse;

class Program
{
    static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if(time >= 6 && time <= 11)
        {
            Console.WriteLine("Gunaydin");
        }
        else if(time <= 18)
        {
            Console.WriteLine("Iyi Gunler");
        }
        else
        {
            Console.WriteLine("Iyi Geceler");
        }

        string sonuc = time >= 6 && time <= 11 ? "Gunaydin" : time <= 18 ? "Iyi Gunler" : "Iyi Geceler";
        Console.WriteLine(sonuc);
    }
}
