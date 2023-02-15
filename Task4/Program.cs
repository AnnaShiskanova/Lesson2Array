// напишите программу, которая на вход будет принимать два числа, а на выходе будет
//показывать, является ли одно число кратно другому. Если число 1 не кратно числу 2, то программа выводит 
//остаток. Например:
//34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter first number");
string numA = Console.ReadLine();
int a = Convert.ToInt32(numA);
Console.WriteLine("Enter second number");
string numB = Console.ReadLine();
int b = Convert.ToInt32(numB);
if (a % b == 0)
    Console.WriteLine($"{a} кратно {b}");
else 
{
    int ost = a % b;
    Console.WriteLine($"Не кратно, остаток {ost}");
}


        
