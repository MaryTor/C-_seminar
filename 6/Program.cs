﻿//Задача 6: Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("ВВедите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введенное число ");
Console.Write(number1 % 2 == 0 ? "- четное" : "- нечетное");

