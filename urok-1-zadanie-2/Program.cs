// По заданному номеру дня недели вывести его название

Console.WriteLine("Введите число от 1 до 7 включительно: ");
int day_number = int.Parse(Console.ReadLine());
if (day_number<=0 || day_number>=8)
{
    Console.WriteLine("Вы ввели число вне заданного промежутка.");
}
else if (day_number==1)
{
    Console.WriteLine("Понедельник");
}
else if (day_number==2)
{
    Console.WriteLine("Вторник");
}
else if (day_number==3)
{
    Console.WriteLine("Среда");
}
else if (day_number==4)
{
    Console.WriteLine("Четверг");
}
else if (day_number==5)
{
    Console.WriteLine("Пятница");
}
else if (day_number==6)
{
    Console.WriteLine("Суббота");
}
else
{
    Console.WriteLine("Воскресенье");
}

