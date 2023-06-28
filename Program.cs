/*
// Задача 1.
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введитеколичество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int [] randomArray = new int [a];
void mas (int a)
{
     for(int i = 0; i < a; i ++)
     {
        randomArray[i] = new Random().Next(100, 1000);
        Console.Write(randomArray[i] + " ");
    }
}
 int kol(int[] randomArray)
 {
     int kol = 0;
    for(int i = 0; i < randomArray.Length; i ++)
    {
        if(randomArray[i] % 2 == 0)
            kol = kol + 1;
     }
    return kol;
 }
 mas(a);
Console.Write($"\n Колличество четных чисел в массиве: {kol(randomArray)}");
*/

// Задача 2.
// Задайте одномерный массив,
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];
for(int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 9);
    Console.Write(randomArray[i]+ " ");
}
Console.WriteLine();
int kol(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while(i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}

Console.Write($"Cумма элементов, стоящих на нечетных позициях: {kol(randomArray)}");


/*
// Задача 3.
// Задайте массив целых двухзначных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int a = 6;
int[] mas = new int[a];
int b = 0;
Random r = new Random();
while(a>b)
{
    mas[b] = r.Next(100,999);
    b = b +1;
}
Console.WriteLine(string.Join(", ", mas));

int max = mas[0];
int min = mas[0];
b = 0;
while(a > b)
{
    if(mas[b] > max)
    {
        max = mas[b];
    }
    if(mas[b] < min)
    {
        min = mas[b];
    }
    b = b + 1;
}
Console.WriteLine("max:{0}; min:{1}; ", max, min);
Console.WriteLine("Разница: {0}", max-min );
*/

