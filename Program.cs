// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write ("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
// int N= X%10;
// Console.WriteLine(N);

int SumNum (int x)
{
    int sum=0;
    while (x>1)
    {
        sum=sum+x%10;
        x=x/10;
    }
    return sum;
}

Console.WriteLine($"Суммачисел в числе: {SumNum (x)}");