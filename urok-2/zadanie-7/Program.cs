// Определить количество цифр в числе

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int length = (int)Math.Log10(number) + 1;
Console.WriteLine($"В числе {length} цифр");
