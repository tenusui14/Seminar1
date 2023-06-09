//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите число a:");
string? numberA = Console.ReadLine();
int nA = Convert.ToInt32(numberA);
Console.WriteLine("Введите число b:");
string? numberB = Console.ReadLine();
int nB = Convert.ToInt32(numberB);
if (nA > nB){
    
    Console.Write("max = ");
    Console.WriteLine(nA);
    Console.Write("min = ");
    Console.WriteLine(nB);
}
if (nA < nB){

    Console.Write("max = ");
    Console.WriteLine(nB);
    Console.Write("min = ");
    Console.WriteLine(nA);
}
if (nA == nB){ Console.WriteLine("Числа равны.");
   }