using System;
using static System.Console;
/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
 элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int PrintNumberMN(int start, int end) //это и есть метод !! рекурсии
{
  if (start == end)
    return start;//переменную start (int) и вывод(!!рекурсия завершена)
  return (start + PrintNumberMN(start + 1, end));//!!!особенно этот момент нужно понимать
}

Clear();
Write("Введите значение(m): ");
int m = int.Parse(ReadLine());
Write("Введите значение(n): ");
int n = int.Parse(ReadLine());

int sum = 0; 
sum += PrintNumberMN(m, n);
WriteLine($"M = {m}; N = {n} -> " + sum);


