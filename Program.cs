// Task 54
void Zadacha54()
{
    int rows = 3;
    int columns = 4;

    int[,] numbers = new int[rows, columns];
    FillArr(numbers);
    SortFromMaxToMin(numbers);
    FindMinSum(numbers);
}

void FillArr(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
            Console.Write(numbers[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

void SortFromMaxToMin(int[,] numbers)
{
    Console.WriteLine("отсортированный массив:");
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int Max = numbers[i, 0];
        for (int j = 0; j < columns; j++)
        {
           int f = j + 1;
           while (f < columns)
           {
                if (numbers[i, j] < numbers[i, f])
                {
                    Max = numbers[i, f];
                    numbers[i, f] = numbers[i, j];
                    numbers[i, j] = Max;
                }
                f++;            
           }
           Console.Write(numbers[i, j] + " ");

        }
       Console.WriteLine();
    }
}

// Task 56
void FindMinSum(int[,] numbers)
{
    int index = 0;
    int minSum = 100;
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            
            sum = sum + numbers[i, j];
        }
        Console.WriteLine($"Сумма строки = " + sum);
        if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
        
    }
    Console.WriteLine($"Строка с минимальной суммой - {index + 1}");
}
Zadacha54();

