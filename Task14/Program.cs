/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратa от 1 до N.
5 -> 1, 4, 9, 16, 25.
5 2 -> 1,4.
*/
int GetNumber(string massege)
{
    int result = 0;
    while (true)
    {
        Console.Write(massege);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}
void GetSquare(int n)
 {
for (int i = 1; i <= n; i++)
{
Console.WriteLine($"{i*i}, ");
}
}

int n = GetNumber("Введите число N: ");
GetSquare (n) ;