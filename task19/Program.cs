// по заданному номеру четверти , показывает диапазон возможных координат
Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());
// if(number >= 1 && number <= 4)
if (number == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (number == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (number == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (number == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// string[] arr={"x>0 и y>0","x<0 и y>0","x<0 и y<0","x>0 и y<0"};
// System.Console.WriteLine("Введите номер четверти");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num==1){
// System.Console.WriteLine($"Номер четверти{arr[num-1]}");
// }
// else if(num==2){
// System.Console.WriteLine($"Номер четверти{arr[num-1]}");
// }
// else if(num==3){
// System.Console.WriteLine($"Номер четверти{arr[num-1]}");
// }
// else if(num==4){
// System.Console.WriteLine($"Номер четверти{arr[num-1]}");
// }



// Console.Write("Введите номер четверти -> ");
// int num = Convert.ToInt32(Console.ReadLine());
// string[] list = {"x > 0 and y > 0", "x < 0 and y > 0", "x < 0 and y < 0", "x > 0 and y < 0"};

// Console.WriteLine(list[num-1])




// string [] quarters = {"x > 0; y > 0",// 0
//                       "x < 0; y > 0",// 1
//                       "x < 0; y < 0",// 2
//                       "x > 0; y < 0"// 3
// };
// Console.WriteLine("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());
// if(quarter >= 1 && quarter <= 4)
// {
//     Console.WriteLine(quarters[quarter-1]);
// }
// else
// {
//     Console.WriteLine("Такой четверти нет");
// }
