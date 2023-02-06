//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа

Console.Clear();
Console.Write("ВВедите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number <100 || number > 999)
{
    Console.WriteLine("Введено не правильное число");
    return;
}
int otvet = number /10 % 10;
Console.WriteLine($"Вторая цифра: {otvet}");