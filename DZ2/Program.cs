// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите первое число ");
string inputStrihga = Console.ReadLine();
int a = Convert.ToInt32(inputStrihga);

Console.Write("Введите второе число ");
string inputStrihgb = Console.ReadLine();
int b = Convert.ToInt32(inputStrihgb);

Console.Write("Введите третье число ");
string inputStrihgc = Console.ReadLine();
int c = Convert.ToInt32(inputStrihgb);

int max = a;

if (b>max) max = b;
if (c>max) max = c;

Console.Write($"Максимальное число {max}");