// Задача 32: Напишите программу 
// замена элементов массива: 
// положительные элементы замените 
// на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2

// Console.WriteLine("введите число, которое хотите найти: ");
// int number = Convert.ToInt32(Console.ReadLine);

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(10, 99);
// }
// Console.Write('[' + string.Join(", ", array) + "]");
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] > 0)
//         array[j] = array[j] * -1;
//     else
//     {
//         array[j] = array[j] * -1;
//     }
// }

// Console.Write('[' + string.Join(", ", array) + "]");


// Задача 33: Задайте массив. 
// Напишите программу, которая определяет,
//  присутствует ли заданное число 
//  в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    } 
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);

Console.WriteLine(string.Join(", ", array));
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isOk = false;
for (int i = 0; i < array.Length;i++)
{
    if (number == array[i])
    {
        isOk = true;
        break;
    }
}
if(isOk)
{
    Console.WriteLine("элемент найден");
}
else{
    Console.WriteLine("не найден");
}
// Можно еще одну переменную добавить, в которую будет писаться количество раз, которое заданное число встретилось
