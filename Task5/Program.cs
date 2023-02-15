// напишите программу, которая принимает на вход число и проверяет является ли оно одновременно
// кратным 7 и 23
//Например:
// 16 -> нет
// 64 -> нет
// 161 -> да

Console.WriteLine("Input number");
string A = Console.ReadLine();
int a = Convert.ToInt32(A);
if (a % 7 == 0 && a % 23 == 0)
Console.WriteLine($"Число {a} кратно 7 и 23");
else 
Console.WriteLine("Число не кратно 7 и 23");

