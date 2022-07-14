{
    // ввод данных
    Console.WriteLine("Введите 1-е число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 3-е число: ");
    int numberC = Convert.ToInt32(Console.ReadLine());
    int max = numberA;
    // условие
    if (numberA > max) max = numberA;
    if (numberB > max) max = numberB;
    if (numberC > max) max = numberC;
    Console.Write("Ответ:");
    Console.WriteLine(max);  
                   
}