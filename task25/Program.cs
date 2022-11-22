// программа принимает на вход число А, и выдаёт сумму чисел от 1 до A
// Console.WriteLine("Введите число А:");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= A; i++)
// {
//     sum = sum + i;
// }
// Console.WriteLine("Сумма чисел равна:" + sum);
 
 // решение методом целочисленным
//  int sum(int number)
//  {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//      sum = sum + i;
//     }
//     return sum;
//  }
// Console.WriteLine("Введите число А:");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = sum(A);
// Console.WriteLine("Сумма чисел равна:" + sum);
 
int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = Sum(A);
Console.WriteLine("Сумма чисел A равна " + sum);

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int sum2 = Sum(B);
Console.WriteLine("Сумма чисел B равна " + sum2);// к методу можно обращаться несколько раз

// Console.WriteLine("Введите А");
// int A = Convert.ToInt32(Console.ReadLine());
// int i;
// int sum = 1;
// for (i = 1; i < A; i++, sum+=i); // sum переместили
// Console.WriteLine(sum);
