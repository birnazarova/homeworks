// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Задай число A: "); //25
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Задай число N: "); //5
int N = int.Parse(Console.ReadLine());

if (A%N==0) Console.WriteLine($"Число {A} кратно {N}");
else Console.WriteLine($"Остаток от деления {A} на {N} равен " + A%N);