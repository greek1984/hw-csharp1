/* Вид 1
void Method1()
{
    Console.WriteLine("Text - ");
}

//Method1();

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Text writing: ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;        
    }
}
//Method21("Text", 3); 
//Method21(count: 3, msg: "new words"); 

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// Вид 4

//string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    } 
    return result;
}

//string res = Method4(10, "written");
//Console.WriteLine(res);


string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "written");
Console.WriteLine(res);



for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");        
    }
    Console.WriteLine();
}

string text = "Я думаю, сказа князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; 
        else result = result + $"{text[i]}";       
    }
 
    return result;
}                

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);                   


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 2, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{  
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;         
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    
}
PrintArray(arr); 
SelectionSort(arr);

PrintArray(arr);    

Завешение данных по лекции*/


// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/* void Task24()

{
    int number = 11;
    int count = 1;
    int sum = 0;

    while (count <= number )
    {
        sum += count;
        Console.WriteLine(count + " + ");
        count++;
    }
    Console.Write("\b\b= ");
    Console.WriteLine(sum);   
}

Task24();     */


//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Task25()

{

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt16(Console.ReadLine());
double result = (Math.Pow(numberA, numberB));
Console.Write("Получаем ответ: " + result);

}

//Task25();

/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

void Task26()

{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int counter = 0;
    while (number > 0)
    {
        number /= 10;
        counter++;
    }
    Console.Write("Получаем: " + counter); 

}

Task26(); */


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11   82 -> 10   9012 -> 12

void Task27()

{

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (numberA > 0)
{ 
    int numberB = numberA % 10; 
    numberA /= 10;
    sum = sum + numberB;
}
Console.Write(sum);  

}

//Task27();

/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

void Task28()

{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int counter = 1;
    while (number > 0)
    {
        counter++;
    }
    Console.Write("Получаем: " + counter); 

}

Task28(); */


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]    */


void Task29()

{

int size = 8;  // задаётся длина массива
Random random = new Random();  // значения под каждый элемент выбираются случайно
int[] array = new int[size]; // создание массива для переменной "array"

    for (int i = 0; i < array.Length; i++)   // цикл for для вывода  >>
    {
        array[i] = random.Next(-100, 100);   // >>  случайных элементов массива со значениями от -99 до 99   
        Console.Write(array[i] + " ");   
    }  
    Console.WriteLine(); 
    for (int i = 0; i < array.Length; i++) // внешний цикл для перебора элементов массива 
    {
        int minPosition = i;  // задаётся позиция мин. по значению элемента 
        for (int j = i; j < array.Length; j++) // внутренний цикл по перебору элементов массива по новому счётчику
        {
            if (Math.Abs (array[j]) < Math.Abs (array[minPosition])) minPosition = j; // условие определения >> 
        }                                                                             // по модулю мин. эл-та в цикле 
        int temporary = array[i];        // swap позиций текущего эл-та с мин. по значению эл-том  
        array[i] = array[minPosition];
        array[minPosition] = temporary; 
        Console.Write(array[i] + " ");  // вывод отсортированного на увеличение по модулю массива
    }
        
}

Task29();


/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void Task30()

{

int size = 10;
Random random = new Random();
int[] array = new int [size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 2);
}
for (int i = 0; i > array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

}

Task30();    */

/*
Даны два массива. В первом массиве записано количество мячей, забитых футбольной командой в той или иной игре,
во втором — количество пропущенных мячей в этой же игре. 
а) Для  каждой  проведенной  игры  напечатать  словесный  результат:  "выигрыш", "ничья" или "проигрыш". 
б) Определить количество выигрышей данной команды. 
в) Определить  количество  выигрышей  и  количество  проигрышей  данной   команды. 
г) Определить количество выигрышей, количество ничьих и количество проигрышей данной команды. 
д) Определить,  в  скольких  играх  разность  забитых  и  пропущенных  мячей  была большей или равной трем. 
е) Определить общее число очков, набранных командой (за выигрыш даются 3 очка, за ничью — 1, за проигрыш — 0). 
*/

/*void Football();

{

Random random = new Random();
int size = random.Next(6, 10);
int[] scored = new int[size];
int[] conceded = new int[size];

for (int i = 0; i < array.Length; i++)
{
    scored[i] = random.Next(0, 2);
}
Console.WriteLine("Забитые мячи: ");

for (int i = 0; i < array.Length; i++)
{
    conceded[i] = (conceded[i] +, 2);
}
Console.WriteLine("Пропущенные мячи: ");


}   

Football();  */