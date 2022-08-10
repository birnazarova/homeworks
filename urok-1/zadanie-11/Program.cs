// Найти третью цифру числа или сообщить, что её нет

int number = new Random().Next(100,1000);
Console.WriteLine(number);

int digit2 = number%100%10;

Console.WriteLine($"Цифры {digit2} нет");