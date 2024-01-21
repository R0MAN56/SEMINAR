Console.Clear();


// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true)
// {
//     Console.Write("Введите целое число или 'q' для выхода: ");
//     string input = Console.ReadLine()!;
//     if (input == "q")
//     {
//         Console.WriteLine("[STOP]");
//         break;
//     }
//     int num;
//     if (int.TryParse(input, out num))
//     {
//         int sum = 0;
//         while (num > 0)
//         {
//             sum += num % 10;
//             num /= 10;
//         }
//         if (sum % 2 == 0)
//         {
//             Console.WriteLine("[STOP]");
//             break;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
//     }
// }


// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] numbers = new int[4];
// int cnt = 0;
// Random num = new();
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = num.Next(100, 1000);
//     Console.Write(numbers[i] + " ");
//     if (numbers[i] % 2 == 0)
//     {
//         cnt++;
//     }
// }
// Console.WriteLine($"\nКоличество четных чисел в массиве: {cnt}");


// Задача 3: Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем.

// int[] numbers = { 1, 3, 5, 6, 7, 8 };
// int temp;
// Console.Write("Исходный массив: ");
// foreach (int number in numbers)
// {
//     Console.Write(number + " ");
// }
// for (int i = 0; i < numbers.Length / 2; i++)
// {
//     temp = numbers[i];
//     numbers[i] = numbers[numbers.Length - 1 - i];
//     numbers[numbers.Length - 1 - i] = temp;
// } 
// Console.Write("\nПеревернутый массив: ");
// foreach (int number in numbers)
// {
//     Console.Write(number + " ");
// }