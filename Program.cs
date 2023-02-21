//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.Write("Введите число :");
int[] number = new int[6];

for (int i = 0; i < number.Length; i++)
{
  number[i] = Convert.ToInt32(Console.ReadLine());
}

double result = Math.Sqrt(Math.Pow((number[3] - number[0]), 2) + Math.Pow((number[4] - number[1]), 2) + Math.Pow
((number[5]) - number[2], 2));
System.Console.WriteLine(result);
