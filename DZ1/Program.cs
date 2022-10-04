// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньше
Console.Clear();
Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a > b)
{
    Console.Write($"Число {a} больше чем число {b}");
}
if (a < b)
{
    Console.Write($"Число {b} больше чем число {a}");
}
if (a == b)
{
    Console.Write($"Число {a} равно числу {b}");
}