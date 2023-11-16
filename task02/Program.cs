﻿/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число M: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = SumNumbers(m, n);

        Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");
    }

    static int SumNumbers(int m, int n)
    {
        if (m > n)
            return 0;
        else
            return m + SumNumbers(m + 1, n);
    }
}