﻿// промежуток чисел от -N до N
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int i = -1 * number;
while (i <= number)
{
    Console.Write($"{i} ");
    i++; //i =  i + 1
}