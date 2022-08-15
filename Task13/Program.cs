// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
//Неявно с какого конца, и в тестах тоже, поэтому 3ю с конца вывожу

int FindThirdNumber(int number) 
{
    int TirdNum;
    if (number > 99)
    
        TirdNum = ((number / 100) % 10);
    else
        TirdNum =  -1;  

    return TirdNum;     
}

Console.WriteLine("Input number ");
int NewNum = Convert.ToInt32(Console.ReadLine());
NewNum = FindThirdNumber(NewNum);

if (NewNum == -1)
    Console.WriteLine("третьей цифры нет");    
else
    Console.WriteLine($"{NewNum}");     



