// Найти кубы чисел от 1 до N

Console.Write("Задайте число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[N];
int pow = 3;

for (int i=0; i < N; i++) //1 2 3
{
    Console.WriteLine($"Куб числа {i} = {Math.Pow(i, pow)}");
}
