// напишите программу, которая на вход принимает трехзначное число
// и на выходе показывает вторую цифру этого числа
//например 485 -> 8; 357 -> 5; 471 -> 7

Console.WriteLine("Enter three-digit number");
int x = Convert.ToInt32(Console.ReadLine());
if (x / 100 == 0 || x / 100 > 9)
Console.WriteLine("This number is not correct, please enter three-digit number");
else
{
    int z = x / 10;
    int c = z % 10;
    Console.WriteLine($"{c}");
}
