// 1 Задание: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
Console.WriteLine("Введите число a:");
string? numberA = Console.ReadLine();
int numberAint = Convert.ToInt32(numberA);
Console.WriteLine("Введите число b");
string? numberB = Console.ReadLine();
int numberBint = Convert.ToInt32(numberB);

if (numberBint * numberBint == numberAint) {
    Console.WriteLine("Число является квадратом второго");
}
else{ 
    Console.WriteLine("Число не является квадратом второго");
}

