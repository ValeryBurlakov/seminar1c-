// // Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 
// // 7 и 23.

// // 14 -> нет 
// // 46 -> нет 
// // 161 -> да
// // 8,9  ->  нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int mod = number1 % number2;
int mod2 = number1 % number3;
if(mod == 0 && mod2 == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine("Число не кратно");
}

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if ((number%7 == 0) && (number%23 == 0))
// {
//     Console.WriteLine("Число кратно и 7 и 23");
// }
// else
// {
//     Console.WriteLine("Число не кратно");
// }

