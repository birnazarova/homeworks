// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Задайте первое число: ");
int first_number = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второе число: ");
int second_number = int.Parse(Console.ReadLine());

if (first_number==second_number*second_number) Console.WriteLine("Первое число является квадратом второго числа");
else if (second_number==first_number*first_number) Console.WriteLine("Второе число является квадратом первого числа");
else Console.WriteLine("Одно число не является квадратом другого");
