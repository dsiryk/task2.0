using System.ComponentModel.Design;

Console.WriteLine("Введіть вік людини:");
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


  /*  if (vik >= 6 || vik > 65)
{ int a = 1; }

        if (vik >= 7 && vik <= 12)
{ int a = 2; }

        if (vik >= 13 && vik <= 17)
{ int a = 3; }

        if (vik >= 18 && vik <= 64)
{
    int a = 4;
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







/*}
else
        if (a = 3)
{
    Console.WriteLine(
    }
    {
        int b = 1;
    }



}
if (vik <= 1 || vik > 100)
    ;

        /*

"Безкоштовно", якщо вік до 6 років або старший за 65.
"Дитячий квиток (50 грн)", якщо вік від 7 до 12.
"Підлітковий квиток (80 грн)", якщо вік від 13 до 17.
"Дорослий квиток (120 грн)", якщо вік від 18 до 64.
"Помилка", якщо вік менше 0 або більший за 100.
        

switch (a)
{
// See https://aka.ms/new-console-template for more information
    case 0: Console.WriteLine("ok");
        break;
    case 1: Console.WriteLine("fuck");
        break;
    case 2: Console.WriteLine("now");
        break;
    case 3: Console.WriteLine("uoy");
        break;
        */
  










