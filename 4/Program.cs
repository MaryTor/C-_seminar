//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел.

Console.Clear();
Console.Write("ВВедите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("ВВедите третье число: ");
int num3 = int.Parse(Console.ReadLine());
int Max=num1;
if ( num2 > Max) Max=num2;
if ( num3 > Max) Max=num3;
Console.Write("Максимальное число =   ");
Console.Write (Max);