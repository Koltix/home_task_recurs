// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void GetListNatNums(int m, int n)
{
    if (m <= n)
    { 
        Console.Write($"{m} ");
        GetListNatNums (m +1, n); 
    }
}

Console.WriteLine("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа от {m} до {n}:");
GetListNatNums(m, n);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


        // Примеры вызовов функции Аккермана
        Console.WriteLine($"A(1, 1) = {Ackermann(0, 1)}");
        Console.WriteLine($"A(2, 2) = {Ackermann(2, 1)}");
        Console.WriteLine($"A(3, 3) = {Ackermann(3, 2)}");
        Console.WriteLine($"A(0, 4) = {Ackermann(0, 4)}");
    

    int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


        int[] array = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);
    

    void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReverse(array, index - 1);
        }
    }