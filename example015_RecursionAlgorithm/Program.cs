// string[,] table = new string[2, 5];
// table[1, 2] = "word";
// for (int row = 0; row < 2; row++)
// {
//     for (int column = 0; column < 5; column++)
//     {
//         Console.Write($"-{table[row, column]}-\n");
//     }
// }



//--------------------------------

int[,] matrix = new int [3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.Write($"\n");
PrintArray(matrix);

//--------------------------------

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        matr[i, j] = new Random().Next(1,10);
        }
    }
}

//--------------------------------

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i, j]} ");
        }
    Console.Write($"\n");
    }
}