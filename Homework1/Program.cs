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

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row,col]} ");
        }

        Console.WriteLine();
    }
}

int[] SortingRow(int[,] array, int row)
{
    int[] newarray = new int[array.GetLength(1)];
        
    for (int col = 0; col < array.GetLength(1); col++)
    {
        newarray[col] = array[row,col];            
    }
    Array.Sort(newarray);
    Array.Reverse(newarray);
    return newarray;
}

void SortingArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        int[] newarray = SortingRow(array,row);

        for (int col = 0; col < array.GetLength(1); col++)
        {
            int index = col;
            array[row,col] = newarray[index];         
        }        
    }       
}

int row = PrintAndGetValue("Чему равно количество строк");
int col = PrintAndGetValue("Чему равно количество стобцов");
int[,] matrix = CreateMatrix(row,col);
Console.WriteLine("Изначальный массив:");
PrintMatrix(matrix);
Console.WriteLine("Отсортированный массив:");
SortingArray(matrix);
PrintMatrix(matrix);

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}