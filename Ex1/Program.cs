void FillArray(double [,] arr)
{
    Random random = new Random();
	for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = random.NextDouble() * 10 - 5;   
        }
    }
}

void PrintArray(double [,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
     { 
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write((Math.Round(arr[i, j],2)) +  " ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int  columnCount = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rowCount, columnCount];

FillArray(array);
PrintArray(array);