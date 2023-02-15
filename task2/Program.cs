// напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру из этого числа
// например 456 -> 46, 532 -> 52
Random number = new Random();
int num = number.Next(100,1000);
Console.WriteLine($"The first number is {num}");
int a = num / 100;
int b = num % 10;
Console.WriteLine($"The number is {a}{b}");