using System;

 
System.Console.WriteLine("Enter day of the week: ");
string week = Console.ReadLine();


switch (week)
{
    case "Dushanba":
        System.Console.WriteLine("Monday");
        break;
    case "Seshanba":
        System.Console.WriteLine("Tuesday");
        break;
    case "Chorshanba":
        System.Console.WriteLine("Wednesday");
        break;
    case "Payshanba":
        System.Console.WriteLine("Thursday");
        break;
    case "Juma":
        System.Console.WriteLine("Friday");
        break;
    case "Shanba":
        System.Console.WriteLine("Saturday");
        break;
    case "Yakshanba":
        System.Console.WriteLine("Sunday");
        break;
    default:
        System.Console.WriteLine("Sizda yozuvda xato bor!");
        break;

}
