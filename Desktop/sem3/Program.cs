/*
void Task17()
{

    Random oneOf = new Random();
    int x = oneOf.Next(-10, 10);
    int y = oneOf.Next(-10, 10);
    Console.WriteLine($"Точка с координатами x={x}, y={y})");

    if (x > 0 && y > 0)Console.WriteLine("Точка лежит в 1-й четверти");
    if (x < 0 && y > 0)Console.WriteLine("Точка лежит в 2-й четверти");
    if (x < 0 && y < 0)Console.WriteLine("Точка лежит в 3-й четверти");
    if (x > 0 && y < 0)Console.WriteLine("Точка лежит в 4-й четверти");
    if (x == 0 || y == 0)Console.WriteLine("Точка располагается на коорд. прямой!");

}  
 
Task17(); 

void Task18()
{

    Random random = new Random();
    int quarter = random.Next(1, 5);

    Console.WriteLine($"Точка в четверти ({quarter})");

    if (quarter == 1) Console.WriteLine("x > 0, y > 0");
    else if (quarter == 2) Console.WriteLine("x < 0, y > 0");
    else if (quarter == 3) Console.WriteLine("x < 0, y < 0");
    else if (quarter == 4) Console.WriteLine("x > 0, y < 0");

}

for (int i = 1; i < 6; i++)
Task18(); */


// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Task19()

{

    Console.WriteLine("Введите 5-значное число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    int numberB = numberA % 10;
    int temp1 = numberA / 10;
    int numberC = temp1 % 10;
    int temp2 = temp1 / 10;
    int numberD = temp2 % 10;
    int temp3 = temp2 / 10;
    int numberE = temp3 % 10;
    int temp4 = temp3 / 10;
    int numberF = temp4 % 10;

    if (numberA < 10000 && numberA > 99999)
    {
        Console.WriteLine("Нужно ввести 5-значное число!");
    }     
    if (numberB == numberF && numberC == numberE)
    {
        Console.WriteLine("-> да");
    }
    else 
        Console.WriteLine("-> нет");

}

Task19();

/*void Task20()
{
    Console.WriteLine("Введите A[x]: ");  // ввод коорд. 1-й точки по x
    int numberAx = Convert.ToInt16(Console.ReadLine()); 
    Console.WriteLine("Введите A[y]: ");  // ввод коорд. 1-й точки по y
    int numberAy = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[x]: ");  // ввод коорд. 2-й точки по x
    int numberBx = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[y]: ");  // ввод коорд. 2-й точки по y
    int numberBy = Convert.ToInt16(Console.ReadLine());
    
    double result = Math.Sqrt((Math.Pow(numberBx - numberAx, 2) + Math.Pow(numberAy - numberBy, 2)));
    Console.Write($"Расстояние между точками: ");
    Console.WriteLine(Math.Round(result, 3));

}

Task20();


void Task20var2()

{

    Console.WriteLine("Введите A[x]");
    int numberAx = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите A[y]");
    int numberAy = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[x]");
    int numberBx = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[y]");
    int numberBy = Convert.ToInt16(Console.ReadLine());
    double D = Math.Sqrt((Math.Pow(numberAx - numberBx, 2) + Math.Pow(numberAy - numberBy,2)));
    Console.WriteLine(Math.Truncate(100 * D) / 100);

}

Task20var2() */


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Task21()

{

    Console.WriteLine("Введите A[x]");
    int numberAx = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите A[y]");
    int numberAy = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите A[z]");
    int numberAz = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[x]");
    int numberBx = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[y]");
    int numberBy = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[z]");
    int numberBz = Convert.ToInt16(Console.ReadLine());

    double result = Math.Sqrt((Math.Pow(numberBx - numberAx, 2) + Math.Pow(numberAy - numberBy, 2) + Math.Pow(numberBz - numberAz, 2)));
    Console.Write($"Расстояние между точками: ");
    Console.WriteLine(Math.Round(result, 3));

}

//Task21();



/*void Task22()

{

    Console.WriteLine("Введите число");
    int number = Convert.ToInt16(Console.ReadLine());
    int startnumber = 0;
    while(number != startnumber) 
    {
        startnumber+=1;
        Console.WriteLine(Math.Pow(startnumber, 2));
    }


}

//Task22(); 

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.


void Task22two()

{

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt16(Console.ReadLine());
    int baseNumber = 0;
    while (number >= baseNumber)
    {
        baseNumber++;
        Console.WriteLine(Math.Pow(baseNumber, 2));
    }
    
}


//Task22two(); */


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Task23()

{

    Console.Write("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
   
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
    Console.WriteLine("");

}

//Task23();