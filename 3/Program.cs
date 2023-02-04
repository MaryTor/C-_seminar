// Программа вывода дня недели по номеру.


Console.Clear();
Console.Write("ВВедите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine());
if (numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("ВВеден не правильный номер!");
    return;
}

if (numberDay == 1)
{
    Console.WriteLine("Понедельник");
}
if (numberDay == 2)
{
    Console.WriteLine("Вторник");
}
if (numberDay == 3)
{
    Console.WriteLine("Среда");
}
if (numberDay == 4)
{
    Console.WriteLine("Четверг");
}
if (numberDay == 5)
{
    Console.WriteLine("Пятница");
}
if (numberDay == 6)
{
    Console.WriteLine("Суббота");
}
if (numberDay == 7)
{
    Console.WriteLine("Воскресенье");
};