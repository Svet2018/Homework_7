// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//либо значение элемента в двумерном массиве, 
//и возвращает значение либо индекс этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
//4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
//2, 3 -> такой элемент есть и равен 4
//5, 5 -> такой элемент отсутствует

void GenerateArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = new Random().Next(1,101);
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

int row = new Random().Next(9,10);
int col = new Random().Next(9,10);

int [,] newArray = new int [row, col];
System.Console.WriteLine();
GenerateArray(newArray);
PrintArray(newArray);
System.Console.WriteLine();

System.Console.WriteLine($"Введите значение элемента (например: 19) или позицию элемента через запятую (например: 5,2)");
string value = Console.ReadLine();

bool contains = value.Contains(',');

string[] splitdata = value.Split(',');

int counter = newArray.Length;

if (contains == true)
{   
    int contains0 = Convert.ToInt32(splitdata[0]);
    int contains1 = Convert.ToInt32(splitdata[1]);

    if (contains0 > row || contains1 > col)
    {
        System.Console.WriteLine($"Вы ввели позицию элемента ({value}), такой позиции в данном массиве нет.");
    }
    else
    {
        System.Console.WriteLine($"Вы ввели позицию элемента ({value}), что соответствует числу {newArray[contains1, contains0]}");
    }
}
else
{
    int numLength = Convert.ToInt32(value);
    
    for (int i = 0; i < row; i++)
    {  
        for (int j = 0; j < col; j++)
        { 
            if (numLength == newArray[i,j])
            {
                System.Console.WriteLine($"Индекс введенного числа {value} в массиве равен ({i} , {j})");   
            }  
            else
            {        
               counter--;               
            }                       
        } 
    }
    if (counter == 0) System.Console.WriteLine($"Вы ввели число {value}, такого числа в массиве нет.");
}



/* Верное решение


void GenerateArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] = new Random().Next(1,101);
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

int row = new Random().Next(9,10);
int col = new Random().Next(9,10);

int [,] newArray = new int [row, col];
System.Console.WriteLine();
GenerateArray(newArray);
PrintArray(newArray);
System.Console.WriteLine();

System.Console.WriteLine($"Введите значение элемента (например: 19) или позицию элемента через запятую (например: 5,2)");
string value = Console.ReadLine();

bool contains = value.Contains(',');

string[] splitdata = value.Split(',');


if (contains == true)
{  
    
    int contains0 = Convert.ToInt32(splitdata[0]);
    int contains1 = Convert.ToInt32(splitdata[1]);
    if (contains0 > row || contains1 > col)
    {
        System.Console.WriteLine($"Вы ввели позицию элемента ({value}), такой позиции в данном массиве нет.");
    }
    else
    {
        System.Console.WriteLine($"Вы ввели позицию элемента ({value}), что соответствует числу {newArray[contains1, contains0]}");
    }
}
else
{
    int numLength = Convert.ToInt32(value);
    
    for (int i = 0; i < row; i++)
    {  
        for (int j = 0; j < col; j++)
        { 
            if (numLength == newArray[i,j])
            {
                System.Console.WriteLine($"Индекс введенного числа {value} в массиве равен ({i} , {j})");    
            }                      
        }
    }
}
*/