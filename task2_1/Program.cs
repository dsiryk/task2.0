// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введiть будь яке число для перевiрки, (дiапазон вiд 10 до 50):");
double a = Convert.ToDouble(Console.ReadLine());
if (a >= 10 && a <= 50)
    Console.WriteLine(true);
else Console.WriteLine(false);
