// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("точка находится в первой четверти");

}
else if(x < 0 && y > 0)
{
    Console.WriteLine("точка находится во второй четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("точка находится в третьей четверти");
}
else
{
    Console.WriteLine("точка находится в четвертой четверти");
}