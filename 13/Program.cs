// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("ВВедите число: ");
int number = int.Parse(Console.ReadLine());
if (number <100)
{
    Console.Write("третьей цифры нет");
    return;
}
else
{
    while (number > 1000)
    {
        number /= 10; 
    }
}
int otvet = number % 10;
Console.WriteLine($"Третья цифра: {otvet}");