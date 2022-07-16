void Task9()
{

    Random oneOf = new Random();
    int number = oneOf.Next(10, 100);

    Console.WriteLine(number);
    int decimNumbers = number / 10;
    int onesNumbers = number % 10;

    if (decimNumbers > onesNumbers)
    {
        Console.Write(decimNumbers);
    }
    else 
    {
        Console.Write(onesNumbers);
    }
}    

//Task9();

void Task11() 
{

    Random oneOf = new Random();
    int numbers = oneOf.Next(101, 1000);
    Console.WriteLine(numbers);


    int hunds = numbers / 100;
    int ones = numbers % 10;
    Console.Write($"{hunds}{ones}");

}    

//Task11();

void Task12()

{

    Console.WriteLine("Введите 1-е число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int numberC = numberA % numberB;

    if (numberA % numberB == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.Write("Не кратно, остаток ");
        Console.Write(numberC);
    }

}

//Task12();


void Task13()
{

    Console.WriteLine("Введите число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    if (numberA < 100)
    {
        Console.Write("3-й цифры нет");
    }
    else
    {
        while (numberA > 999) 
        {
            numberA /= 10;
        }
        int numberB = numberA % 10;
        Console.WriteLine(numberB);
    }

}

Task13();

void Task14()

{

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    // задаём двойное условие:
    if (number % 7 == 0 || number % 23 == 0)
    {
        Console.WriteLine("-> да");
    } 
    else
        Console.WriteLine("-> нет");

}

//Task14();


void Task15()
{

    Console.WriteLine("Введите число от 1 до 7");
    int dayName = Convert.ToInt32(Console.ReadLine());

    if (dayName < 0 || dayName > 7)
    {
        Console.WriteLine("Вы ввели неверное число!");
    }    
    if (dayName == 6 || dayName == 7)
    {
        Console.WriteLine("Да");
    }
    if (dayName < 6)
    {
        Console.WriteLine("Нет");
    }

}

Task15();

void Task16()

{

    Console.WriteLine("Введите 1-е число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

    if (numberA == numberB * numberB || numberB == numberA * numberA)
    {
        Console.WriteLine("-> да");
    }
    else 
        Console.WriteLine("-> нет");

}

//Task16();