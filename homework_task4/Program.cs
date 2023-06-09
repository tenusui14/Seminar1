// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a:");
string? numberA = Console.ReadLine();
int nA = Convert.ToInt32(numberA);

Console.WriteLine("Введите число b:");
string? numberB = Console.ReadLine();
int nB = Convert.ToInt32(numberB);

Console.WriteLine("Введите число с:");
string? numberC = Console.ReadLine();
int nC = Convert.ToInt32(numberC);

int max = nA;
if(max == nB || max == nC) {
    Console.Write("Все три числа равны. ");
}
if(max < nB) {max = nB;}
if(max < nC) {max = nC;}
   
Console.Write("Максимальное число из введенных: ");
Console.WriteLine(max);