Console.WriteLine("Введiть вiк людини:");
int vik = Convert.ToInt32(Console.ReadLine());
int a = 0;
if (vik <= 1 || vik > 100)
{
    Console.WriteLine("eror");
}
else if (vik >= 6 && vik <= 65)
{

    if (vik >= 7 && vik <= 12)
    { a = 2; }

    if (vik >= 13 && vik <= 17)
    { a = 3; }

    if (vik >= 18 && vik <= 64)
    {
        a = 4;
        if (vik >= 6 && vik <= 65)
        { a = 1; }
    }
            switch (a)
        {
            case 1:
                Console.WriteLine("Безкоштовно");
                break;
            case 2:
                Console.WriteLine("Дитячий квиток (50 грн)");
                break;
            case 3:
                Console.WriteLine("Підлітковий квиток(80 грн)");
                break;
            case 4:
                Console.WriteLine("Дорослий квиток (120 грн)");
                break;
            default:
                Console.WriteLine("Eror");
                break;

        }
    }


  












