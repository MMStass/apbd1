﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mod 1");
for (int i = 0; i < 10; i++)
{
    Console.Write((char)(i + 97) + " ");
}
Console.WriteLine();
Console.Write("Podaj liczbę: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine(x*4);
Console.WriteLine();
int[] tab = new int[10];
for (int i = 0;i < tab.Length;i++) 
{
    tab[i] = i*i;
}

tab.ToList().ForEach(t => Console.WriteLine(t));