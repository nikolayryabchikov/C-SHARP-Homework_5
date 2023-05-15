// Homework 5
// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArr(int size)
// {
//     int[] array = new int [size];

//     for(int i = 0; i < size; i++) 
//         array[i]= new Random().Next(100,1000);
//     return array;
// }
// int SearchEvenNum (int[] array)
// {
//     int count =0;

//     for(int i =0; i < array.Length; i++)
//         if (array[i] %2 ==0)
//             count++;
//         Console.WriteLine($"всего {array.Length} числа, {count} из них чётные");
//     return count;
// }


// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] result = CreateArr(size);
// ShowArray(result);
// Console.WriteLine(SearchEvenNum(result));

// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateArr(int size, int min, int max)
// {
//     int[] array = new int [size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(min, max);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }


// int SumOfUnevenIndex(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (i % 2 != 0)
//             sum += array[i];
//     return sum;
// }

// Console.Write("Задайте размер массива ");
// int size =Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min =Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max =Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateArr( size,min,max);
// ShowArray(arr);

// Console.WriteLine(SumOfUnevenIndex(arr));

// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreateArr(int size, int min, int max)
// {
//     double[] array = new double[size];

//     for(int i = 0; i < size; i++) 
//         array[i] = Math.Round(new Random().NextDouble()+ new Random().Next(min, max)  , 2);

//     return array;
// }

// void DiffBetweenNum (double[] array)
// {

//     double min = array[0];
//     double max = array[0];

//     for(int i = 0; i < array.Length; i++)
//     {
//         if (min > array[i])
//             min = array[i];
//         else if (max < array[i])
//             max = array[i];
//     }
//     Console.WriteLine(min + " - минимальное, " + max + " - максимальное.");
// }   

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] array= CreateArr(size, min, max);
// DiffBetweenNum(array);
// ShowArray(array);
