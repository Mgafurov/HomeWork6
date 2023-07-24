/*Создайте массив из любых целых чисел, обязательно чтобы там были и положительные и отрицательные значения. Найдите максимальный элемент в массиве. Замените все элементы массива на максимальный элемент.
Пример массива: [-1, 1, 2, 3]. Результат: [3, 3, 3, 3];*/

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { -3, 7, -2, 10, -5 };

        int maxElement = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxElement)
            {
                maxElement = numbers[i];
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = maxElement;
        }
        Console.WriteLine("Результат: [{0}]", string.Join(", ", numbers));
        Console.ReadKey();
    }
}*/
/*Создайте массив из любых целых чисел, обязательно чтобы там были и положительные и отрицательные значения. Найдите минимальный элемент в массиве. Замените все элементы массива на минимальный элемент.
Пример массива: [-1, 1, 2, 3]. Результат: [-1, -1, -1, -1];*/

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { -5, 10, -3, 7, 2, -8, 9, -1 };
        int minElement = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < minElement)
            {
                minElement = numbers[i];
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = minElement;
        }
        Console.WriteLine("Результат: [{0}]", string.Join(", ", numbers));
        Console.ReadKey();
    }
}*/

/*Создайте массив из любых целых чисел, обязательно чтобы там были и положительные и отрицательные значения, длина массива должна быть чётной. Попарно пройдитесь по массиву, и замените значение наименьшего соседа на наибольшее.
Пример массива: [-1, 1, 2, 3]. Результат: [1, 1, 3, 3];*/

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { -5, 10, -3, 7, 2, -8, 9, -1 };
        for (int i = 0; i < numbers.Length - 1; i += 2)
        {
            int minNeighborIndex = (numbers[i] < numbers[i + 1]) ? i : i + 1;
            int maxNeighborIndex = (numbers[i] > numbers[i + 1]) ? i : i + 1;

            numbers[minNeighborIndex] = numbers[maxNeighborIndex];
        }
        Console.WriteLine("Результат: [{0}]", string.Join(", ", numbers));
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[] numbers = { -1, 1, 2, 3, 7, -3, 4, -6 };
        for (int i = 0; i < numbers.Length - 1; i += 2)
        {
            int minNeighborIndex = (numbers[i] < numbers[i + 1]) ? i : i + 1;
            int maxNeighborIndex = (numbers[i] > numbers[i + 1]) ? i : i + 1;

            numbers[maxNeighborIndex] = numbers[minNeighborIndex];
        }
        Console.WriteLine("Результат: [{0}]", string.Join(", ", numbers));
        Console.ReadLine();
    }
}*/


//Пользователь вводит N (вводится с консоли) вещественных чисел, которые программа должна заносить в массив. Затем вводится число K. Определить сколько в массиве чисел меньших K, равных K, больших K.

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во ээлементов в массив (N): ");
        int N = int.Parse(Console.ReadLine());
        double[] numbers = new double[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Введите число: ");
            numbers[i] = double.Parse(Console.ReadLine());
        }
        Console.Write("Введите число K: ");
        double K = double.Parse(Console.ReadLine());
        int countLessThanK = 0;
        int countEqulaToK = 0;
        int countGreaterThanK = 0;
        for(int i = 0; i < N; i++)
        {
            if (numbers[i] > K )
            {
                countLessThanK++;
            }
            else if (numbers[i] == K)
            {
                countEqulaToK++;
            }
            else 
            {
                countGreaterThanK++;
            }
        }
        Console.WriteLine("Чисел меньше K: " + countLessThanK);
        Console.WriteLine("Чисел равных K: " + countEqulaToK);
        Console.WriteLine("Чисел больше K: " + countGreaterThanK);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите количество элементов в массиве (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] numbers = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Введите число: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Результат:");
        int start = numbers[0];
        string currentLine = start.ToString();
        for (int i = 1; i < N; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                currentLine += " " + numbers[i];
            }
            else
            {
                Console.WriteLine(currentLine);
                currentLine = numbers[i].ToString();
            }
        }
        Console.WriteLine(currentLine);
    }
}*/

/*Пользователь вводит N (вводится с консоли) целых чисел, которые программа должна заносить в массив. Вывести только те элементы, которые располагаются в виде возрастающей последовательности друг за другом с разницей в единицу.
Пример массива: [-1, 5, 6, 0, -3, 1, 2, 9, 10]. Результат: «5 6 \n 1 2 \n 9 10»*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве (N): ");
        int N = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Введите число: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Результат:");
        for (int i = 1; i < N; i++)
        {
            if (numbers[i] == numbers[i - 1] + 1)
            {
                Console.Write(numbers[i - 1] + " " + numbers[i] + "\n");
            }
        }
        Console.ReadKey();
    }
}*/

//Пользователь вводит N (вводится с консоли) целых чисел, которые программа должна заносить в массив. Вывести только те элементы значения которых являются степенями двойки (1, 2, 4, 8, 16, 32…)

/*using System;

class Program
{
    static void Main()
    {
        // Ввод количества элементов массива N
        Console.Write("Введите количество элементов в массиве (N): ");
        int N = int.Parse(Console.ReadLine());

        // Создание массива и ввод значений от пользователя
        int[] numbers = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Введите число: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Вывод элементов, являющихся степенями двойки
        Console.WriteLine("Результат:");
        for (int i = 0; i < N; i++)
        {
            int num = numbers[i];
            bool isPowerOfTwo = true;

            while (num > 1)
            {
                if (num % 2 != 0)
                {
                    isPowerOfTwo = false;
                    break;
                }
                num /= 2;
            }

            if (isPowerOfTwo && numbers[i] > 0)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        Console.ReadKey();
    }
}*/

//Найти сумму всех элементов массива целых чисел, удовлетворяющих условию: остаток от деления на 2 равен 3. Размерность массива – 30. Заполнение массива осуществить случайными числами от 200 до 300.

/*using System;

class Program
{
    static void Main()
    {
        int size = 30;
        int[] numbers = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(201, 300);
        }
        Console.WriteLine("Массив:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 3)
            {
                sum += number;
            }
        }
        Console.WriteLine("Сумма элементов, удовлетворяющих условию (остаток от деления на 2 равен 3): " + sum);
        Console.ReadKey();
    }
}*/

/*using System;
class Program
{
    static void Main()
    {
        int size = 20;
        double[] numbers = new double[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.NextDouble() * 50 + 50;
        }
        Console.WriteLine("Массив: ");
        foreach (double number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.Write("Введите число для сравнения: ");
        double compareNumber = double.Parse(Console.ReadLine());
        double sum = 0;
        foreach (double number in numbers)
        {
            if (number > compareNumber)
            {
                sum += number;
            }
        }
        Console.WriteLine("Суммал элементов заданного числа: " + sum);
        Console.ReadKey();
    }
}*/

//Найти произведение всех элементов массива вещественных чисел, меньших заданного числа (вводится с консоли). Размерность массива – 15. Заполнение массива осуществить случайными числами от 50 до 100.

/*using System;

class Program
{
    static void Main()
    {
        int size = 15;
        double[] numbers = new double[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.NextDouble() * 50 + 50;
        }
        Console.Write("Массив: ");
        foreach(double number in numbers)
        {
            Console.WriteLine(number + " ");
        }
        Console.WriteLine();
        Console.Write("Введите число для сравнения: ");
        double compareNumber = double.Parse(Console.ReadLine());
        double product = 1;
        foreach(double number in numbers)
        {
            if(number < compareNumber)
            {
                product *= number;
            }
        }
        Console.WriteLine("Произведение элементов, меньших заданного числа: " + product);
        Console.ReadKey();
    }
}*/
/*
using System;

class Program
{
    static void Main()
    {
        int size = 10; ;
        int[] numbers = new int[size];
        Random random = new Random();
        for(int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(5,201);
        }
        Console.WriteLine("Массив: ");
        foreach(int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        int product = 1;
        foreach(int number in numbers)
        {
            if(number % 3 == 0 && number % 9 == 0)
            {
                product *= number;
            }
        }
        Console.WriteLine("Произведение элементов, кратных 3 и 9: " + product);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int size = 25;
        int[] numbers = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(151, 300);
        }
        Console.WriteLine("Массив: ");
        foreach(int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        double average = 0;
        foreach(int number in numbers)
        {
            average += number;
        }
        average /= size;
        int sum = 0;
        foreach (int number in numbers)
        {
            if(number < average)
            {
                sum += number;
            }
        }
        Console.WriteLine("Сумма элементов,которые меньше среднего арифметического: " + sum);
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[,] X = new int[5, 4];
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                X[i, j] = random.Next(1, 11);
            }
        }
        Console.WriteLine("Массив до замены: ");
        for (int i = 0; i < 5; i++)
        {
            for(int j = 0;j < 4; j++)
            {
                Console.Write(X[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0;i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (X[i,j]<5)
                {
                    X[i, j] = 111;
                }
            }
        }
        Console.WriteLine("\nМассив после замены: ");
        for(int i = 0; i <5; i++)
        {
            for( int j = 0; j <4; j++)
            {
                Console.Write(X[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[,] B = new int[4, 3];
        Random random = new Random();
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                B[i, j] = random.Next(1, 11);
            }
        }
        Console.WriteLine("Массив до замены: ");
        for(int i = 0;i < 4;i++)
        {
            for(int j=0; j < 3; j++)
            {
                Console.Write(B[i, j] + " ");
            }
            Console.WriteLine();
        }
        for(int i = 0; i <4;i++)
        {
            for(int j = 0;j < 3; j++)
            {
                B[i,j] = B[i, j] * B[i, j];
            }
        }
        Console.WriteLine("\nМассив после замены: ");
        for(int i = 0;i<4; i++)
        {
            for(int j = 0;j < 3; j++)
            {
                Console.Write(B[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        double[,] A = new double[5, 3];
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                A[i, j] = (random.NextDouble() * 21) - 10;
            }
        }
        Console.WriteLine("Массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nИндексы отрицательных элементов:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (A[i, j] < 0)
                {
                    Console.WriteLine("Индексы [" + (i + 1) + ", " + (j + 1) + "]");
                }
            }
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[,] F = new int[5, 3];
        Random random = new Random();
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                F[i, j] = random.Next(1, 21);
            }
        }
        Console.WriteLine("Массив: ");
        for(int i = 0;i < 5; i++)
        {
            for(int j =0; j < 3; j++)
            {
                Console.Write(F[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nЭлементы кратные 5 и их числам: ");
        for( int i = 0; i <5; i++)
        {
            for( int j =0; j < 3;j++)
            {
                if (F[i , j] % 5 == 0)
                {
                    Console.WriteLine("Элемент: " + F[i, j] + " индексы: [" + (i + 1) + ", " + (j + 1) + "]");
                }
            }
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[,] W = new int[5, 5];
        Random random = new Random();
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                W[i, j] = random.Next(1, 11);
            }
        }
        Console.WriteLine("Массив: ");
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0;j < 5; j++)
            {
                Console.Write(W[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nЛевая диагональ: ");
        for( int i = 0;i < 5; i++)
        {
            Console.Write(W[i, i] + " ");
        }
        Console.WriteLine("\nПрвая диагональ: ");
        for (int i = 0; i < 5;i++)
        {
            Console.Write(W[i, 5 - i - 1] + " ");
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[5, 5];
        for(int i = 0; i < 5; i++)
        {
            int rowSum = 0; //Храним переменную суммы элементов строки
            for(int j = 0; j < 5; j++)
            {
                matrix[i, j] = i + j;
                rowSum += matrix[i, j];
            }
            Console.WriteLine("Сумма элементов строки" + (i + 1) + ": " + rowSum);
        }
        Console.WriteLine("\nМатрица: ");
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0;j < 5; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[m, n];
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(1, 101);
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (matrix[i, j] < matrix[i, k])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }
        Console.WriteLine("\nУпорядоченная матрица:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[6, 5];
        Random random = new Random();
        for(int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }
        Console.WriteLine("Исходный массив: ");
        for(int i = 0;i < 6; i++)
        {
            for (int j = 0;j < 5; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int maxAverrageRowIndex = 0;
        double maxAverrage = 0;
        for(int i = 0; i < 6 ; i++)
        {
            double sum = 0;
            for(int j = 0; j < 5 ; j++)
            {
                sum += array[i, j];
            }
            double averrage = sum / 5;
            if(averrage > maxAverrage)
            {
                maxAverrage = averrage;
                maxAverrageRowIndex = i;
            }
        }
        Console.WriteLine("\nНомер строки с максимальным среднеарифметическим значением: " + (maxAverrageRowIndex + 1));
        Console.ReadKey();
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[5, 9];
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int l = 0; l < 9; l++)
                    {
                        if (array[i, j] > array[k, l])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[k, l];
                            array[k, l] = temp;
                        }
                    }
                }
            }
        }
        Console.WriteLine("\nМассив после обмена строк и столбцов с одинаковыми номерами:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}*/

using System;

class Program
{
    static void Main()
    {
        int[,] table = new int[5, 5];
        Random random = new Random();
        for(int i = 0; i <5; i++)
        {
            for(int j = 0; j <5; j++)
            {
                table[i, j] = random.Next(-50, 51);
            }
        }
        Console.WriteLine("Исходная таблица: ");
        for(int i = 0; i <5;i++)
        {
            for (int j = 0;j <5;j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int minPositive = int.MaxValue;
        int minRowIndex = -1;
        int minColIndex = -1;
        for(int i = 0;i <5;i++)
        {
            for(int j =0;j <5;j++)
            {
                if (table[i, j]>0 && table[i , j]<minPositive)
                {
                    minPositive = table[i, j];
                    minRowIndex = i;
                    minColIndex = j;
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            int temp = table[minRowIndex, i];
            table[minRowIndex, i] = table[i, minColIndex];
            table[i, minColIndex] = temp;
        }
        Console.WriteLine("\nТаблица после обмена элементов строки и столбца с минимальным положительным элементом:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}




















