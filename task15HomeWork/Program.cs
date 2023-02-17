// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Input number");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1:
        Console.WriteLine($"{x} is a Monday. It's not weekend.");
        break;
    case 2:
        Console.WriteLine($"{x} is a Tuesday. It's not weekend.");
        break;
    case 3:
        Console.WriteLine($"{x} is a Wednesday. It's not weekend.");
        break;
    case 4:
        Console.WriteLine($"{x} is a Thursday. It's not weekend.");
        break;
    case 5:
        Console.WriteLine($"{x} is a Friday. It's not weekend.");
        break;
    case 6:
        Console.WriteLine($"{x} is a Saturday. It's weekend.");
        break;
    case 7:
        Console.WriteLine($"{x} is a Sunday. It's weekend.");
        break;
    default:
        Console.WriteLine("This number is not Day");
        break;
}     
  
