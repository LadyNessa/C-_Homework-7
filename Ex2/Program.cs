Console.WriteLine("Введите индекс строки: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int  l = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int [3,4] {
        {1, 2, 3, 4 },
        {5, 6, 7, 8 },
        {9, 10, 11, 12 }
};

if (k < 3 & l < 4)
{
    Console.Write("Искомый элемент: ");
    Console.WriteLine(arr[k,l]);
}
else
{
    Console.WriteLine("Такой элемент не существует");
}