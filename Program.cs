// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// int [] Array (int size){
//     int [] arr = new int [size];
//     for(int i = 0; i < size; i++){
//        arr[i] = new Random().Next(100, 1000);
//     }
//     return arr;
// }
// void PrintArray(int [] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// void EvenNum (int [] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] % 2 == 0){
//             count++;
//         }
//     }
//     Console.Write($"-> {count}");
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = Array(size);
// PrintArray(array);
// EvenNum(array);


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// int [] RandomArray (int size, int minValue, int maxValue){
//     int [] arr = new int [size];
//     for(int i = 0; i < size; i++){
//        arr[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return arr;
// }
// void ShowArray(int [] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// void Number (int [] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] >= 10 && array[i] <= 99) count++;
//     }
//     Console.Write($"-> {count}");
// }
// int size = 123;
// Console.Write("Введите минимальное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = RandomArray(size, min, max);
// ShowArray(array);
// Number(array);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int [] RandomArray (int size, int minValue, int maxValue){
//     int [] arr = new int [size];
//     for(int i = 0; i < size; i++){
//        arr[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return arr;
// }
// void ShowArray(int [] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// void Summ(int [] arr){
//     int sum = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(i % 2 != 0) sum = sum + arr[i];
//     }
//     Console.Write($"-> {sum}");
// }
// Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = RandomArray(size, min, max);
// ShowArray(array);
// Summ(array);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double [] RandomArray (int size, double minValue, double maxValue){
//     double [] arr = new double [size];
//     for(int i = 0; i < size; i++){
//        arr[i] = minValue + new Random().NextDouble()*(maxValue-minValue);
//     }
//     return arr;
// }
// void ShowArray(double [] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// void Diff(double [] arr){
//     double min = arr[0];
//     double max = arr[0];
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] <= min){
//             min = arr[i];
//             i++;
//         }
//         if(arr[i] >= max){
//             max = arr[i];
//             i++;
//         }
//     }
//     double subtract = (max - min);
//     Console.WriteLine($"-> {subtract}");
// }
// Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элемента массива: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента массива: ");
// double max = Convert.ToDouble(Console.ReadLine());
// double [] array = RandomArray(size, min, max);
// ShowArray(array);
// Diff(array);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// int [] RandomArray (int size, int minValue, int maxValue){
//     int [] arr = new int [size];
//     for(int i = 0; i < size; i++){
//        arr[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return arr;
// }
// void ShowArray(int [] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }
// void ShowNewArray(int [] array){
//     int n = array.Length-1;
//     for(int i = 0; i <= n; i++){
//         if(i<n){
//             array[i] = array[i]*array[n];
//             n -= 1;
//         }
//         Console.Write($"{array[i]} ");
//     }
// }
// Console.Write("Введите длину массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элемента массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элемента массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Заданный массив: ");
// int [] array = RandomArray(size, min, max);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine("Полученный массив: ");
// ShowNewArray(array);