// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что ее нет
// например: 645 -> 5; 25 -> третьей цифры нет; 32456 -> 4

Console.WriteLine("Enter number");
int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string y = Convert.ToString(x);
Console.WriteLine("The length of {0} is {1}", y, y.Length);
for (int i = 0; i < y.Length; i++)
{
    char d = y[i];  
if (i == 2)  
    Console.WriteLine($"The number with position 3 is {d}");
else 
    Console.WriteLine(" ");
}
if (y.Length < 3)
Console.WriteLine("Error! The number with position 3 is not found.");