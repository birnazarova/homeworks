// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int number = new Random().Next(1,8);
Console.WriteLine(number);

if (number==1 || number==2 || number==3 || number==4 || number==5) Console.WriteLine("Это не выходной");
else Console.WriteLine("Это выходной");
