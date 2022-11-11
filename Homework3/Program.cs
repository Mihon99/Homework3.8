int[,] CreateMatrix( int m, int n)
{
    int[,] a = new int[m,n];
    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            a[row,col] = new Random().Next(1,10);
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

int Сomposition(int[,] firstmatrix, int frow, int[,] secondmatrix, int scol)
{
    int composition = 0;

        for (int fcol = 0; fcol < firstmatrix.GetLength(1); fcol++)
        {
            for (int srow = 0; srow < secondmatrix.GetLength(0); srow++)
            {
                composition = composition + firstmatrix[frow,fcol] * secondmatrix[srow,scol];
                fcol++;                
            }
                        
        }

    
    return composition;
}

int[,] СompositionMatrix(int[,] firstmatrix, int[,] secondmatrix)
{
    
    int[,] newmatrix = new int[firstmatrix.GetLength(0),secondmatrix.GetLength(1)];
    
    for (int row = 0; row < newmatrix.GetLength(0); row++)
    {    
        for (int col = 0; col < newmatrix.GetLength(1); col++)
        {
            int composition = Сomposition(firstmatrix,row,secondmatrix,col);            
            newmatrix[row,col] = composition;                        
        }
    }
    return newmatrix;       
}

int firstrow = PrintAndGetValue("Чему равно количество строк в первой матрице");
int firstcol = PrintAndGetValue("Чему равно количество стобцов в первой матрице");
int[,] firstmatrix = CreateMatrix(firstrow,firstcol);
int secondrow = PrintAndGetValue("Чему равно количество строк во второй матрице");
int secondcol = PrintAndGetValue("Чему равно количество стобцов во второй матрице");
int[,] secondmatrix = CreateMatrix(secondrow,secondcol);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstmatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondmatrix);
int[,] resultmatrix = СompositionMatrix(firstmatrix,secondmatrix);
Console.WriteLine("Полученная матрица:");
PrintMatrix(resultmatrix);


int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}