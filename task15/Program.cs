// // Напишите программу, которая принимает на вход 
// два числа и проверяет, является ли одно число 
// квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1*number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("является квадратом");
}
else
{
Console.WriteLine("Не является квадратом");
}

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// System.Console.Write("Введите первое число\t");
// int numberA= Convert.ToInt32 (Console.ReadLine());

// System.Console.Write("Введите Второе число\t");
// int numberB= Convert.ToInt32 (Console.ReadLine());

// if (numberA*numberA==numberB || numberB*numberB==numberA){
// System.Console.Write($"да");
// }
// else{
//     System.Console.Write($"нет");
// }

