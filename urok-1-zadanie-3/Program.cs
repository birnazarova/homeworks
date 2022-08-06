// Найти максимальное из трех чисел

Console.WriteLine("Введите первое число: ");
int first_number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second_number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int third_number = int.Parse(Console.ReadLine());

int max=first_number; 
if (second_number>first_number && second_number>third_number)
{
    max=second_number;
}
else if (third_number>second_number && third_number>first_number)
{
    max=third_number;
}

Console.WriteLine($"Максимальное из трех чисел: {max}");