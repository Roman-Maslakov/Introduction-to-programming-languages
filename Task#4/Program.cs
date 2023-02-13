// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Please, gimme a number");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Here is your row of even numbers");

if (N % 2 == 0)
{
    for (int i = 1; i <= N; i++)
    {
        if (i == N)
        {
            Console.Write(i);
        }
        else if (i % 2 == 0)
        {
            Console.Write(i);
            Console.Write(", ");
        }
    }
}
else
{
    for (int i = 1; i <= N; i++)
    {
        if (i == N - 1)
        {
            Console.Write(i);
        }
        else if (i % 2 == 0)
        {
            Console.Write(i);
            Console.Write(", ");
        }
    }
}