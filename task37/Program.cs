// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 100);
//     } 
//     return arr;
// }

// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));
// // int minposition = 9;
// // int maxposition = 100;
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         count++;
//     i++;
//     }
// }
// Console.WriteLine(count);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 100);
//     } 
//     return arr;
// }

// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(num);
// Console.WriteLine(string.Join(", ", array));
// int j = array.Length - 1;
// int[] sumarr = new int [(j - j/2)];
// for (int i = 0; i < sumarr.Length; i++, j--)
// {
//     if (i == j)
//     {
//         sumarr[i] = array[i];
//         break;
//     }

//     sumarr[i] = array[i] * array[j];
    
// }
// Console.WriteLine(string.Join(" ", sumarr));



// int[] FillArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }
//     return arr;
// }
// Console.Write("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillArray(num);
// int num1 = num / 2 + num % 2;
// int[] NewArr = new int[num1];
// Console.WriteLine(string.Join(", ", arr));

// if (num % 2 != 0)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//         NewArr[i] = arr[i] * arr[arr.Length - 1 - i];
//     NewArr[num1 - 1] = arr[num1 - 1];
// }
// else
//     for (int i = 0; i < arr.Length / 2; i++)
//         NewArr[i] = arr[i] * arr[arr.Length - 1 - i];

// Console.WriteLine(string.Join(", ", NewArr));



int[] FillArray(int size)
{
    
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));

int newLength = array.Length % 2 + array.Length/2;
int[] newArray = new int[newLength];
for(int i = 0; i < array.Length/2; i++)
{
    newArray[i] = array[i] * array[array.Length-1-i];
}
if (array.Length % 2 > 0)
{
    newArray[newArray.Length-1] = array[array.Length/2];
}
Console.WriteLine(string.Join(", ", newArray));
