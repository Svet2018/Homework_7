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
           array[i,j] = new Random().Next(1,5);
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
System.Console.WriteLine();

string answer = String.Empty;

for(int i = 0; i < newArray.GetLength(1); i++)
{
    double sum = 0;
    for (int x = 0; x < newArray.GetLength(0); x++)
        {
            sum = sum + newArray[x, i];
        }
    answer = answer + (sum/newArray.GetLength(0)).ToString("F02") + "; "; 
}

answer = answer.Remove(answer.Length - 2) + ".";
System.Console.WriteLine($"Среднеарифметическое каждого из столбцов равно: {answer}");


