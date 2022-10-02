// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


 Console.WriteLine("Выберете задачу 34 / 36 / 38");
int task = int.Parse(Console.ReadLine());

switch (task)
{
     case 34: Task34();
   break;
   case 36: Task36();
   break;
   case 38: Task38();
   break;
   default : 
   Console.WriteLine("Это нам не задавали! Это мы не проходили");
   break;
}

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}    

void Task34()
{
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
Console.WriteLine("Введите размер массива:");

int size = Convert.ToInt32(Console.ReadLine());

int [] array = FillArray(size,99,1000); 

 Console.WriteLine("Массив: [ " + String.Join(",",array) + " ]");
 int even = 0;
 for (int i = 0; i < size; i++)
 {
    if (array [i]%2 == 0) even+=1;
 }
Console.WriteLine($" Количество Четных чисел {even} ");
}
void Task36()
{
    Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное возможное значение чисел в массиве:");
int min = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное возможное значение чисел в массиве:");
int max = int.Parse(Console.ReadLine());

int [] array = FillArray(size,min,max); 
Console.WriteLine("Массив: [ " + String.Join(",",array) + " ]");
int sum36 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2==0)
    {
        sum36=sum36+array[i];
        Console.Write($"[ {array[i]} ] ");
    }
}
Console.WriteLine($" Сумма чисел на нечетных позичиях {sum36} ");
}
void Task38()
{
Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("Введите размер массива  ");

int size = int.Parse(Console.ReadLine());

double[] array = new double[size];
FillArrayDouble(array);
 Console.WriteLine("Массив: [ " + String.Join(",",array) + " ]");
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];       
}

Console.WriteLine($"мах= {max}, min = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayDouble(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
        numbers[i] = Convert.ToDouble(new Random().Next());
        }
}
}