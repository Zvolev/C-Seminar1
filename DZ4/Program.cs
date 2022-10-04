// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 (i) до N.

Console.Clear();

Console.Write("Введите целое число больше 0 ");
string inputStrihgN = (Console.ReadLine()?? "0");
int N = Convert.ToInt32(inputStrihgN);
int i = 1;

while(i <= N)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);        
    }
    i++;
}