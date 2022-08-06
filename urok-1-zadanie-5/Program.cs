// Показать числа от -N до N

Console.WriteLine("Введите любое целое число: ");
int N = int.Parse(Console.ReadLine());

int[] array1 = Enumerable.Range(-N, N).ToArray();
int[] array2 = Enumerable.Range(0, N+1).ToArray();
Console.WriteLine(string.Join(",", array1)+","+string.Join(",", array2));