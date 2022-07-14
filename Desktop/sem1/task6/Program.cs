{

// вводное число
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// условие проверки
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} - чётное число");
    }
    else
    {
        Console.WriteLine($"{number} - нечётное число");
    }

}    