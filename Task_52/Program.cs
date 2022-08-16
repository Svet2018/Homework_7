// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void GenerateArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = new Random().Next(1,10);
        }
        
    } 
}


void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите количество строк массива. ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива. ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] newArray = new int [row, col];


GenerateArray(newArray);
PrintArray(newArray);

int max = newArray[0,0];
int maxi = 0;
int maxj = 0;

int min = newArray[0,0];
int mini = 0;
int minj = 0;

double arithmeticMean = 0;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        if (newArray[i,j] > max) 
        {
            max = newArray[i,j];
            maxi = i;
            maxj = j;
        }
        if (newArray[i,j] < min) 
        {
            min = newArray[i,j];
            mini = i;
            minj = j;
        }
        arithmeticMean = (arithmeticMean + newArray[i,j]);
    }
   
}
arithmeticMean = arithmeticMean/(row * col);


System.Console.WriteLine($"min = {min}, min[{mini} , {minj}]");
System.Console.WriteLine($"max = {max}, max[{maxi} , {maxj}]");
System.Console.WriteLine(arithmeticMean.ToString("F02"));

