// Напишите программу, которая на вход принимает число и выдаёт, является ли 
// число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Введите первое число ");
string inputStrihga = Console.ReadLine();
int a = Convert.ToInt32(inputStrihga);

if (a % 2 == 0 )
{
    Console.Write($"{a} - четное число");
}
else Console.Write($"{a} - нечетное число");