//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input the first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the third number");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max)
{
    max = b;
    if (c > max)
    {
        max = c;
        Console.Write("The greatest number - ");
        Console.Write(max);
    }
    else
    {
        Console.Write("The greatest number - ");
        Console.Write(max);
    }
}
else 
{
    if (c > max)
    {
        max = c;
        Console.Write("The greatest number - ");
        Console.Write(max);
    }
    else
    {
        Console.Write("The greatest number - ");
        Console.Write(max);
    } 
}

//Возможно более оптимальное решение через case

