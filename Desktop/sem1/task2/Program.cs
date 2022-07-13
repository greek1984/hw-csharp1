{

// ввод 2-х чисел
Console.WriteLine("Введите 1-е число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int numberB = Convert.ToInt32(Console.ReadLine());
// условие сравнения
if (numberA < numberB)
{    
    Console.Write($"max = {numberB}");
}
else     
{
    Console.Write($"max = {numberA}");
}

}