// Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100,1000);
Console.WriteLine($"Число: {number}");

Console.WriteLine("Новое число: " + number/100 + number%100%10);