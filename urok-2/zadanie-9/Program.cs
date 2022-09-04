// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Задайте число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int i = 1;
int multiplication = 1;

while (i<=N)
{
    multiplication=multiplication*i;
    i++;
}

Console.WriteLine(multiplication);

