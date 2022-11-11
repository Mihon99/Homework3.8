void PossibilityOfCalculation( int r, int c, int h)
{
    int index = h * r * c;
    if (index > 90)
    {
        Console.WriteLine($"Такая матрица не может быть создана так как двухзначных чисел только 90, а в вашей матрице {index} элементов");
    }
    else
    {
        int[,,] matrix = new int [r,c,h];
        CreateMatrix(matrix);
        Console.WriteLine("Полйученная матрица:");
        PrintMatrix(matrix);
    }
}

void CreateMatrix( int[,,] a)
{
    int[] temp = new int[a.GetLength(0) * a.GetLength(1) * a.GetLength(2)];
    int number;    
    
    for(int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10,100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10,100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }        
    }
    
    int count = 0;    
    for(int row = 0; row < a.GetLength(0); row++)
    {
        for (int col = 0; col < a.GetLength(1); col++)
        {
            for (int height = 0; height < a.GetLength(2); height++)
            {
                a[row,col,height] = temp[count];
                count++;                         
            }       
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int height = 0; height < matrix.GetLength(2); height++)
            {
                Console.Write($"{matrix[row,col,height]}({row}, {col}, {height}); ");
            }
            
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int height = PrintAndGetValue("Чему равна высота мастрицы");
int row = PrintAndGetValue("Чему равно количество строк");
int col = PrintAndGetValue("Чему равно количество стобцов");
PossibilityOfCalculation(height,row,col);

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}