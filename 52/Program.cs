//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void InputMatrix (int[,] matrix){
    for (int i =0; i < matrix.GetLength(0); i++){
        for (int j =0; j < matrix.GetLength(1); j++){
        matrix[i,j] =  new Random().Next(0,5);
        Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void Release(int[,] matrix){
        for (int i =0; i < matrix.GetLength(1); i++){
           double sum =0;  
            for (int j =0; j < matrix.GetLength(0); j++){
                sum += matrix[j,i];
            }
        Console.Write($"{Math.Round(sum/matrix.GetLength(0),2) }; \t");
        }
}

Console.Clear();
Console.WriteLine("Введите размер массива");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int[size[0],size[1]];

InputMatrix(matrix);
Console.WriteLine("");
Release(matrix);