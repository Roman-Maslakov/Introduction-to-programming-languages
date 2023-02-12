//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Gimme a number");
int EVEN = Convert.ToInt32(Console.ReadLine());

if (EVEN % 2 == 0)
{
    Console.WriteLine("Yes, the number is even");
}
else
{
    Console.WriteLine("No, the number isn't even");
}