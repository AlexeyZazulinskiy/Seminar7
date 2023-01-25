//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

void InputMatrix (int[,] matrix){
    for (int i =0; i < matrix.GetLength(0); i++){
        for (int j =0; j < matrix.GetLength(1); j++){
        matrix[i,j] =  new Random().Next(-10,11);
        Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void Release(int[,] matrix,int[] address){
        if (address[0]< matrix.GetLength(0) && address[1]< matrix.GetLength(1)){
            Console.WriteLine(matrix[address[1],address[0]]);
        } else Console.WriteLine("Элемента нет");
}

Console.Clear();

Console.WriteLine("Введите размер массива через пробел:");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int[size[0],size[1]];

Console.WriteLine("Введите адрес элемента массива через пробел: ");
int[] address = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

InputMatrix(matrix);
Console.WriteLine("");
Release(matrix,address);