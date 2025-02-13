Console.WriteLine("Введіть числа , кожне число з нового рядка");
Console.Write("Введiть 1 сторону: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть 2 сторону: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введiть 3 сторону: ");
double c = Convert.ToDouble(Console.ReadLine());
if (a + b <= c || a + c <= b || b + c <= a)
    Console.Out.WriteLine("Не трикутник");
else if (a == b && b == c)
    Console.Out.WriteLine("Рiвностороннiй");
else if (a == b || a == c || b == c) 
    Console.Out.WriteLine("Рiвнобедрений");
else 
    Console.Out.WriteLine("Рiзностороннiй");
