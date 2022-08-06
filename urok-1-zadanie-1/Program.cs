// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Задайте первое число: ");
int first_number = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второе число: ");
int second_number = int.Parse(Console.ReadLine());

if (first_number==second_number*second_number)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}