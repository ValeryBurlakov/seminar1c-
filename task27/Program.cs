// принимает на вход число и выдает количество цифр
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int number1 = number;
// while (number > 0)
// { number1 /= 10;
// count++;
// }
// Console.WriteLine($"количество цифр в числе {number} равно: {count} ");
// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num;
// int count = 0;

// while(num > 0){
//     num /= 10;
//     count++;
// }

// Console.WriteLine($"Количество цифр в числе {num1} равно {count}");

// факториал числа 28
// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int proiz = 1;
// if (num > 0)
// {
// for (int i = 1; i <= num; i++)
// {
//     proiz *= i;
// }
// Console.WriteLine(proiz);
// }
// else
// {
//     Console.WriteLine("вы ввели отрицательное число");
// }


Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num;
int count = 0;

while(num > 0){
    num /= 10;
    count++;
}

// Console.WriteLine($"Количество цифр в числе {num1} равно {count}");

// Console.Write("Введите число "); // завкернул в метод ещё
// int num = Convert.ToInt32(Console.ReadLine());
// int Proiz(int number){
//     int rezult = 1;
//     for (int i = 1; i <= number; i++){
//         rezult *= i;
//     }
//     return rezult;
// }
// int t = Proiz(num);

// if (num > 0){
    
//     Console.WriteLine($"Произведение чисел от 1 до {num} равно {t}");
// }
// else{
//     Console.WriteLine($"Число {num} меньше единицы, введите еще раз");
// }

// int Factorial(int number)
// {
//     int factorial = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         factorial = factorial * i;
//     }
//     return factorial;
// }
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int factorial = Factorial(A);
// Console.WriteLine("Сумма чисел равна " + factorial);

// Console.WriteLine("Введите число");
// string? A = Convert.ToString(Console.ReadLine());
// if (int.TryParse(A, out int num)) // проверка строки на int
//     Console.Write("Количество цифр в числе: " + A.Length);
// else
//     Console.Write("В строке не только цифры, напишите число");
