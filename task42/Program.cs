// Задача 46: Задайте двумерный массив 
// размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("введите размерность двумерного массима m x n");
// Console.Write("введите m(строку): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите n(столбец): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m, n];


// for(int i = 0; i <m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10); // [1, 10)
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// 48 задача

// Console.WriteLine("введите размерность двумерного массива m x n");
// Console.Write("введите m(строку): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите n(столбец): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m, n];

// for(int i = 0; i <m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = i + j; // [1, 10)
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти 
// элементы на их квадраты.

// Console.WriteLine("введите размерность двумерного массива m x n");
// Console.Write("введите m(строку): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите n(столбец): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m, n];

// for(int i = 0; i <m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10);
//         if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j]; // [1, 10)
//         Console.Write(matrix[i, j] + " ");
//     }
//     Console.WriteLine();
// }
////sdsdfv
// Console.WriteLine("Введите размерность двумерного массива m x n");
// Console.Write("Введите  m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите  n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [m,n];
// for(int i = 0; i < m; i++)
// {
//     for(int j = 0; j < n; j++)
//     {
//         matrix[i,j] = new Random().Next(0,11);
//         Console.Write(matrix[i,j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// for(int i = 0; i < m; i++)
// {
//     for(int j = 0; j < n; j++)
//     {
//         if(i % 2 == 0 && j % 2 == 0){
//         matrix[i,j] = matrix[i,j] * matrix[i,j];
//         }
//         Console.Write(matrix[i,j] + " ");
//     }
//     Console.WriteLine();
// }




// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("введите размерность двумерного массива m x n");
// Console.Write("введите m(строку): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите n(столбец): ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m, n];
// int summ = 0;

// for(int i = 0; i <m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10); // [1, 10)
//         Console.Write(matrix[i, j] + " ");
//         if (i == j) summ += matrix[i, j];
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Сумма чисел по главной диагонали равна: {summ}");
