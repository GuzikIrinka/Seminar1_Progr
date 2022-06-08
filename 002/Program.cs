// максимальное из трех чисел
//using System;
//Console.Write ("Введите первое число ");
//int number1 = Convert.ToInt32 (Console.ReadLine());
//Console.Write ("Введите второе число ");
//int number2 = Convert.ToInt32 (Console.ReadLine());
//Console.Write ("Введите третье число ");
//int number3 = Convert.ToInt32 (Console.ReadLine());
//int max = number1;
//if(number1 >= max)
//{
//    Console.Write("Первое число - наибольшее");
//} 
//else 
//{
//    number2 > max;
//    Console.Write("Второе число - наибольшее");
//}
//else
//{
//    number3 > max;
//        Console.Write("Третье число - наибольшее");
//}

using System;
Console.Write ("Введите первое число ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число ");
int number2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите третье число ");
int number3 = Convert.ToInt32 (Console.ReadLine());
int max = number1;
if (number1 > max)
    number1 = max;
if (number2 > max)
    number2 = max;
if (number3 > max)
    number3 = max;

Console.Write("max = ");
