// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= x)
{

     Console.Write(i*i + " ");// Math.Pow(i, 2);
      i++;
}
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= number; i++)
// {
//     Console.WriteLine(i*i);
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while(count <= number)
// {
//     Console.WriteLine(count*count);
//     count++;
// }

