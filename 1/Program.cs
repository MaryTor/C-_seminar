﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.Clear();
Console.Write("ВВедите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA * numberA == numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}