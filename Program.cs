/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/



/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
/*int Number (int num1)
{
    int index = 0;
    while (num1 > 0)
    {
        num1 /= 10;
        index++;
    }
    return index;
}
void SumNumber(int num2, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num2 % 10;
        num2 /= 10;
    }
    Console.WriteLine(sum);
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numbers = Number(num);
SumNumber(numbers);*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int FilArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(num+1);
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}
Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FilArray(number));

