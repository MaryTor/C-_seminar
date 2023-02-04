// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.


Console.Clear();
Console.Write("ВВедите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if ( number1 > number2)
{
    Console.WriteLine($"Первое число {number1} -большее");
    Console.WriteLine($"Второе число {number2} -меньшее");
    return;
}
if ( number2 > number1);
{
    Console.WriteLine($"Первое число {number1} -меньшее");
    Console.WriteLine($"Второе число {number2} -большее");
}
