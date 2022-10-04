// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите третье число ");
int c = int.Parse(Console.ReadLine() ?? "0");;

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write($"Максимальное число {max}");