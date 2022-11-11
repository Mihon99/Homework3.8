void CreateMatrix( int[,] a, int n)
{    
    int number = 1;
    int col = 0;
    int r = 0;

    if (n % 2 == 0)
    {
        for (int row = 0; row < n / 2; row++)
        {
            for (col = 0; col < n - row; col++)
            {
                a[row,col] = number++;
            }
            for (r = row + 1; r < n - row; r++)
            {
                a[r,n - 1 - row] = number++;
            }
            for (col = n - row - 2; col >= row; col--)
            {
                a[n - 1 -row,col] = number++;
            }
            for (r = n - 2 - row; r > row; r--)
            {
                a[r,row] = number++;
            }        
        }
    }
    else
    {
        for (int row = 0; row <= n / 2; row++)
        {
            for (col = 0; col < n - row; col++)
            {
                a[row,col] = number++;
            }
            for (r = row + 1; r < n - row; r++)
            {
                a[r,n - 1 - row] = number++;
            }
            for (col = n - row - 2; col >= row; col--)
            {
                a[n - 1 -row,col] = number++;
            }
            for (r = n - 2 - row; r > row; r--)
            {
                a[r,row] = number++;
            }                   
        }

    }
    
}

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row, col] < 10)
            {
                Console.Write("0" + array[row, col]);
                Console.Write(" ");
            }
            else Console.Write(array[row, col] + " ");
        }

        Console.WriteLine();
    }
}

int RowAndCol= PrintAndGetValue("Чему равно количество строк и столбцов");
int[,] matrix = new int[RowAndCol,RowAndCol];
CreateMatrix(matrix,RowAndCol);
Console.WriteLine("Полученная матрица:");
PrintMatrix(matrix);

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}