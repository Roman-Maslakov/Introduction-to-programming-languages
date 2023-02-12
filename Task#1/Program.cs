//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input the first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("The greatest number - ");
    Console.Write(a);
}
else
{
    Console.Write("The greatest number - ");
    Console.Write(b);
}
