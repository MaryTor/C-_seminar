// Напишите программу, которая принимает на вход 
//цифру, обозначающую день недели, и проверяет, является ли 
//этот день выходным.
Console.Clear();
Console.Write("ВВедите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine());
if (numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("ВВеден не правильный номер!");
    return;
}

if (numberDay >= 1 && numberDay <= 5)
{
    Console.WriteLine("не является выходным");
    return;
}
if (numberDay >= 6 && numberDay <= 7)
{
    Console.Write("Выходной!!!");
}
