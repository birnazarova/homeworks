// Выяснить является ли число чётным

Console.WriteLine("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());

if (number%2==0)
{
    Console.WriteLine("Число - четное.");
}
else
{
    Console.WriteLine("Число - нечетное.");
}