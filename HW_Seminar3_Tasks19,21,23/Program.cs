// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Console.WriteLine("Enter x1: ");
//int Xa = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y1: ");
// int Ya = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter z1: ");
// int Za = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter x2: ");
// int Xb = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y2: ");
// int Yb = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter z2: ");
// int Zb = int.Parse(Console.ReadLine());

//double AC = (Xb-Xa);
// double BC = (Yb-Ya);
//double ZC = (Zb-Za);
//double AB = Math.Pow(AC,2)+ Math.Pow(BC,2)+Math.Pow(ZC,2);
//double result =Math.Sqrt(AB);

//Console.WriteLine(result);





// Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
double cube = 1;

while (N >= i)
{
    cube = Math.Pow(i,3);
    Console.Write($"{cube}, ");
    i++;
}
