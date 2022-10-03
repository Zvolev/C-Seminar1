// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньше
Console.Clear();
Console.Write("Введите первое число ");
string inputStrihga = Console.ReadLine();
int a = Convert.ToInt32(inputStrihga);

Console.Write("Введите второе число ");
string inputStrihgb = Console.ReadLine();
int b = Convert.ToInt32(inputStrihgb);

if (a > b)
{
    Console.Write($"Число {a} больше чем число {b}");
}
else Console.Write($"Число {b} больше чем число {a}");