// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.Clear();
Console.Write("ВВедите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number <100 || number > 999)
{
    Console.WriteLine("Введено не правильное число");
    return;
}
int otvet = number % 10;
Console.WriteLine($"Третья цифра: {otvet}");