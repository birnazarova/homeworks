// Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Задайте число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int pow = 3;

for (int i=0; i < N; i++) //1 2 3
{
    double cube = Math.Pow(i, pow);
    if (cube%2==0) Console.WriteLine($"Куб числа {i} = {cube}");
}
