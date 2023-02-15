// напишите программу, которая выводит случайное число из отрезка от [10;99] и 
// показывает наибольшую цифру числа, например 78->8

Random createNumber = new Random();
int number = createNumber.Next(10,100);

int a = number / 10; 
int b = number % 10;
if (a > b)
    Console.WriteLine($"Первая цифра больше второй {a} > {b}");
else if (a < b)
    Console.WriteLine($"Вторая цифра больше первой {b} < {a}");
else 
    Console.WriteLine($"Цифры равны {a} == {b}");
// Console.WriteLine ("Случайное число " + number);


