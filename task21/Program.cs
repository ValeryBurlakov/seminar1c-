// принимае на вход координаты двух точек и находит расстояние между ними в 2д пространстве
// A (3,6)
//Math.Sqrt()
//Math.Pow(a, 2)

// Double x1 = 0;
// Double x2 = 0;
// Double y1 = 0;
// Double y2 = 0;
// Double result;
// Console.WriteLine("Введите x1:");
// x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите x2:");
// x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите y1:");
// y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите y2:");
// y2 = Convert.ToDouble(Console.ReadLine());

// result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
// Console.WriteLine($"отрезок равен:  {result}");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine("Введите x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

int TotalX = x1-x2;

int TotalY = y1-y2;

double lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

// double lenght = Math.Round( Math.Sqrt (Math.Pow(TotalX,2) + Math.Pow(TotalY,2)),2); идет результат с округлением
System.Console.WriteLine(lenght);

// |AB|² = (y2 - y1)² + (x2 - x1)² как я понял её надо
// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
