// ввод числа
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 2;
// условие
    while(number <= N) 
    {
        Console.Write(number + ",");
        number += 2;
    }
    if (N < 0)
    {
        Console.WriteLine("Ввдите положительное число!");
    }
Console.WriteLine("\b.");
    

