// Вывести на экран таблицу умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.Write($"{i} * {j} = {i * j}\n");
    }
    Console.Write($"\n");
}