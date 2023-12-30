//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 || number % 23 == 0)
// {
//     Console.WriteLine("Число кратное 7 или 23");
// }
// else
// {
//     Console.WriteLine("Число не кратное ни 7, ни 23");
// }

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите X");
// int numberX = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y");
// int numberY = Convert.ToInt32(Console.ReadLine());
// if (numberX > 0 && numberY > 0)
// {
//     Console.WriteLine("Номер координатной четверти - 1");
// }
// else if (numberX < 0 && numberY > 0)
// {
//     Console.WriteLine("Номер координатной четверти - 2");
// }
// else if(numberX < 0 && numberY < 0)
// {
//     Console.WriteLine("Номер координатной четверти - 3");
// }
// else if (numberX > 0 && numberY < 0)
// {
//     Console.WriteLine("Номер координатной четверти - 4");
// }
// else 
// {
//     Console.WriteLine("Одна из координат = 0");
// }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 10 && number <= 99)
// {
//     int firstNumber = number / 10; 
//     int secondNumber = number % 10;
//     if (firstNumber > secondNumber)
//     {
//         Console.WriteLine($"Наибольшая цифра числа {number}: {firstNumber}");
//     }
//     else if (firstNumber == secondNumber)
//     {
//         Console.WriteLine($"Обе цифры числа {number} равны");
//     }
//     else
//     {
//         Console.WriteLine($"Наибольшая цифра числа {number}: {secondNumber}");
//     }
// }
// else
// {
//     Console.WriteLine("Число не находится в отрезке [10, 99]");
// }

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// Моя прога, которая не вышла и только до 100 работает

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 10;
// int numbers = number / 10;
// int lastNumber = number % 10;
// while(i <= number)
// {
//     if (number >= 10)
//     {
//         Console.WriteLine(number / i);
//         Console.WriteLine(number % i);
//     }
    
//     i *= 10; 
// }

// Как должно быть, но с выводом наоборот
// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
// while (N > 0)
// {
// int currentDigit = N % 10;
// N /= 10;
// if (N > 0)
// {
// Console.Write($"{currentDigit},");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }
// }

