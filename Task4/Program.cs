﻿/* Задача М5. Напишите программу, которая на вход 
принимает одно число (N),а на выходе показывает
 все целые числа в промежутке от -N до N.
 4 -> "-4, -3, -2, -1, 0, 1, 2, 3,4"
 2 -> " -2, -1, 0, 1, 2"
 */
 
 Console.WriteLine("Введите число N: ");
 string numberNStr = Console.ReadLine();
 int numberN = Math.Abs(Convert.ToInt32(numberNStr));
 
 for (int i = -numberN; i <= numberN; i++)
 {
   Console.WriteLine(i);
 }
