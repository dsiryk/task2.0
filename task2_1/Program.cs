Console.WriteLine("Введiть будь яке число для перевiрки, (дiапазон вiд 10 до 50):");
double a = Convert.ToDouble(Console.ReadLine());
string res = a >= 10 && a <= 50 ? "Число в дiапазонi" : "Не в дiапазонi";
Console.WriteLine(res);
