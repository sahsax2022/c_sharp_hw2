// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondNumber(int number) 
{
    int FindNum = number / 10;
    FindNum = FindNum % 10;

    return FindNum;
}

Console.WriteLine("Input 3 chracter number ");
int NewNum = Convert.ToInt32(Console.ReadLine());
NewNum = FindSecondNumber(NewNum);
Console.WriteLine($"Second number is {NewNum}");
