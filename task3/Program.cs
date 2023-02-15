// напишите программу, которая на вход принимает два числа и проверяет, 
//является ли одно число квадратом другого
// пример 5, 25 -> yes; -4, 16 -> yes; 8, 9 -> no
Console.WriteLine("Input first number"); 
string numberA = Console.ReadLine();
int a = Convert.ToInt32(numberA);
Console.WriteLine("Input second number"); 
string numberB = Console.ReadLine();
int b = Convert.ToInt32(numberB);
if (a == b * b)
    Console.WriteLine($"{a} is the square {b}");
else if (b == a*a)
    Console. WriteLine($"{b} is the square {a}");
else 
        Console. WriteLine("Is not square");


