using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите вещественные числа (для остановки введите отрицательное число): ");

        string input = Console.ReadLine();
        string[] numbersStr = input.Split(' ');

        double[] numbers = new double[numbersStr.Length];

        for (int i = 0; i < numbersStr.Length; i++)
        {
            numbers[i] = double.Parse(numbersStr[i]);
            if (numbers[i] < 0)
            {
                Array.Resize(ref numbers, i);
                break;
            }
        }

        if (numbers.Length == 0)
        {
            Console.WriteLine("Массив пустой, так как не было введено положительных чисел.");
            return;
        }

        double min = numbers[0];
        int indexOfMin = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
                indexOfMin = i;
            }
        }

        Console.WriteLine($"Индекс наименьшего элемента в массиве: {indexOfMin}");
    }
}