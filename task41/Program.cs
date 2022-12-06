// 44. числа фибоначчи не рекурсией а циклом.
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int num1 = 0;
// int num2 = 1;
// int buf = 0 ;
// Console.Write($"{num1}");
// for (int i = 1; i <= number - 1; i++)
// {
//      buf = num1 + num2;
//      num2 = num1;
//      num1 = buf;
//      Console.Write($" {num1}");
// }


// Задача 45: Напишите программу, 
// которая будет создавать копию заданного 
// массива с помощью поэлементного 
// копирования.

// int[] FillArray(int size)
// {
    
//     int[] arr = new int[size];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9,10);
//     }
//     return arr;
// }

// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));



// void FillArray (int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//             {
//                 array[i] = new Random().Next(0,100);
//             }
//     }

// void PrintArray (int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//             {
//                 Console.Write($"  {array[i]}");
//             }
//     }

// void CopyArray (int[] array, int[] copyarray)
//     {
//         for (int i = 0; i < array.Length; i++)
//             {
//                 copyarray[i] = array[i];
//             }
//     }
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());   
// int[] firstArray = new int[N]; // наш массив, выделение памяти
// int[] secondArray = new int[N];

// FillArray(firstArray);
// PrintArray(firstArray);// заполнение и вывод первого массива
// Console.WriteLine();
// CopyArray(firstArray,secondArray); // заполнение второго массива элементами первого
// PrintArray(secondArray); // вывод второго массива

// int[] FillArray(int size)
// {
    
//     int[] arr = new int[size];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-9,10);
//     }
//     return arr;
// }

// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));

// int[] newArray = new int[num];
// for(int i = 0; i < array.Length; i++)
// {
//     newArray[i] = array[i];
// }
// Console.WriteLine(string.Join(", ", newArray));


