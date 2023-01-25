// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Average(int num, int n)
// {
//     int result = num;
//     for (int i = 1; i <= n; i++)
//     {
//         result *= num;
//     }
//     return result;
// }


// Console.WriteLine("Input first number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int result = Average(num, n);
// Console.WriteLine("The average is: " + result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int GetSum(int num)
// {   
//     int sum = 0;
//     while(num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return sum;
// }
// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("The sum is: " + GetSum(num));



// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
    Console.WriteLine($"Input a {i + 1} element: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void WriteArray(int[] arr)
{
    int[] temp = arr;

    for(int i = 0; i < arr.Length; i++ )
    {
        Console.WriteLine(temp[i]);
    }
}

Console.WriteLine("Input size: ");
int leng = Convert.ToInt32(Console.ReadLine());

WriteArray(CreateArray(leng));
 