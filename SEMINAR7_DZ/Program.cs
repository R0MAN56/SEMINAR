Console.Clear();

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// int UserNumber(string mess)
// {
//     Console.WriteLine(mess);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// void PrintNaturalNumbers(int M, int N)
// {
//     if (M > N)
//     {
//         PrintNaturalNumbers(M, N + 1);
//         Console.Write($"{N} ");
//     }
//     else if (M < N)
//     {
//         PrintNaturalNumbers(M, N - 1);
//         Console.Write($"{N} ");
//     }
//     else Console.Write($"{N} ");
// }

// int M = UserNumber("Введите число M: ");
// int N = UserNumber("Введите число N: ");
// PrintNaturalNumbers(M, N);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int m = InputNumbers("Введите число m: ");
// int n = InputNumbers("Введите число n: ");

// int FunctAcker = Ack(m, n);

// Console.Write($"Функция Аккермана = {FunctAcker} ");

// int Ack(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else 
//         if (n == 0) 
//         return Ack(m - 1, 1);
//     else 
//         return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// int[] array = { 1, 2, 5, 0, 10, 34 };
// ArrayReverse(array, array.Length - 1);

// void ArrayReverse(int[] array, int index)
// {
//     if (index < 0)
//     {
//         return;
//     }
//     Console.Write(array[index]);
//     Console.Write(" ");
//     ArrayReverse(array, index - 1);
// }
