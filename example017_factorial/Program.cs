// Факториал:

double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 10; i++)
{
    Console.Write($"{i}! = {Factorial(i)}\n");
}


// Числа Фибоначчи:

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++)
{
    Console.Write($"{Fibonacci(i)}\n");
}
