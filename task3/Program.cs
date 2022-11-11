//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница
Console.Write("Введите день недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
     Console.WriteLine("Понедельник");
}
else if (day == 2)
{
     Console.WriteLine("Вторник");
}
else if (day == 3)
{
     Console.WriteLine("Среда");
}
else if (day == 4)
{
     Console.WriteLine("Четверг");
}
else if (day == 5)
{
     Console.WriteLine("Пятница");
}
else if (day == 6)
{
     Console.WriteLine("Суббота");
}
else if (day == 7)
{
     Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Дней всего 7!!!");
}

// через свитч Console.WriteLine("Введите число от 1 до 7");
// int x = Convert.ToInt32(Console.ReadLine());
// switch (x)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         Console.WriteLine("Вторник");
//         break;
//     case 3:
//         Console.WriteLine("Среда");
//         break;
//     case 4:
//         Console.WriteLine("Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Пятница");
//         break;
//     case 6:
//         Console.WriteLine("Суббота");
//         break;
//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;
//     default:
//         Console.WriteLine("Нет такого дня недели");
//         break;
// }


