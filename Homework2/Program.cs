int[,] CreateMatrix( int m, int n)
{
    int[,] a = new int[m,n];
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            a[row,col] = new Random().Next(1,100);
        }       
    }

    return a;

}

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row,col]} ");
        }

        Console.WriteLine();
    }
}

int SummaRow(int[,] array, int row)
{
    int sum = 0;
        
    for (int col = 0; col < array.GetLength(1); col++)
    {
        sum = sum + array[row,col];            
    }
    
    return sum;
}

void SortingSumma(int[,] array)
{
    int minsumma = SummaRow(array,0);
    int index = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        int summa = SummaRow(array,row);        

        if (summa < minsumma)
        {
            minsumma = summa;
            index = index + 1;
        }
        else
        {
            index = index;
        }       
    }
    Console.WriteLine($"Индекс строки с минимальной суммой = {index} Сумма равна = {minsumma}");       
}

int row = PrintAndGetValue("Чему равно количество строк");
int col = PrintAndGetValue("Чему равно количество стобцов");
int[,] matrix = CreateMatrix(row,col);
Console.WriteLine("Изначальный массив:");
PrintMatrix(matrix);
SortingSumma(matrix);


int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}