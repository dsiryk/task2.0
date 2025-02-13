Console.WriteLine("Введiть порядковий номер мiсяця: (межi вiд 1 до 12) ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 12 || a < 1)
{
    Console.WriteLine("eror");
}
else switch (a)
    {
        case 1:
            Console.WriteLine("Січень. Зима. 31 день.");
            break;
        case 2:
            Console.WriteLine("Лютий. Зима. 29 днів (у високосний рік) або 28 днів.");
            break;
        case 3:
            Console.WriteLine("Березень. Весна. 31 день.");
            break;
        case 4:
            Console.WriteLine("Квітень. Весна. 30 днів.");
            break;
        case 5:
            Console.WriteLine("Травень. Весна. 31 день.");
            break;
        case 6:
            Console.WriteLine("Червень. Літо. 30 днів.");
            break;
        case 7:
            Console.WriteLine("Липень. Літо. 31 день.");
            break;
        case 8:
            Console.WriteLine("Серпень. Літо. 31 день.");
            break;
        case 9:
            Console.WriteLine("Вересень. Осінь. 30 днів.");
            break;
        case 10:
            Console.WriteLine("Жовтень. Осінь. 31 день.");
            break;
        case 11:
            Console.WriteLine("Листопад. Осінь. 30 днів.");
            break;
        case 12:
            Console.WriteLine("Грудень. Зима. 31 день.");
            break;











    }