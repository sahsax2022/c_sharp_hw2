// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//
//Неявно с какого конца, и в тестах тоже, поэтому 3ю с конца вывожу

bool FindWeekend(int number) 
{
    return number == 6 || number == 7;     
}

Console.WriteLine("Input number ");
int NewNum = Convert.ToInt32(Console.ReadLine());

bool Res = FindWeekend(NewNum);

Console.WriteLine(Res);    




