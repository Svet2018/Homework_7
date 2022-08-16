// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void GenerateArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           int num = new Random().Next(-100,101);
           double number = Convert.ToDouble(num)/10;
           array[i,j] = number;
        }       
    } 
}

void PrintArray(double [,] array)
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
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива. ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] newArray = new double [m, n];

GenerateArray(newArray);
PrintArray(newArray);