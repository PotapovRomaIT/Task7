Console.Write("Введите M: ");
int Variable_M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int Variable_N = Convert.ToInt32(Console.ReadLine());




// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, не использовать циклы.

void natural_numbers(int first, int past)
{
    if (first + 2 < past)
    {
        natural_numbers(first, past - 1);
    }
    Console.Write($"{past - 1} ");

}

if (Variable_M == Variable_N || Variable_M + 1 == Variable_N || Variable_N + 1 == Variable_M)
{
    Console.WriteLine($"Промежуток натуральных чисел отсутствует.");
}
else if (Variable_M < Variable_N)
{
    Console.Write($"Натуральные числа: ");
    natural_numbers(Variable_M, Variable_N);
}
else
{
    Console.Write($"Натуральные числа: ");
    natural_numbers(Variable_N, Variable_M);
}





// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.


int Ackerman_function(int N, int M)
{
    if (N == 0)
    {
        return M += 1;
    }
    else if (M == 0)
    {
        return Ackerman_function(N - 1, 1);
    }
    else
    {
        return Ackerman_function(N - 1, Ackerman_function(N, M - 1));
    }

}

int Ackerman = Ackerman_function(Variable_N, Variable_M);
Console.WriteLine("");
Console.WriteLine($"По формуле Акермана: {Ackerman}");




// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] mass = [1, 2, 3, 4, 5];
int size = mass.Length;


void print_elements(int[] mass, int size)
{
    if (size == 0)
    {
        return;
    }
    size -= 1;
    int namber = mass[size];
    Console.Write($"{namber} ");
    print_elements(mass, size);
}

Console.Write($"Элементы массива: ");
print_elements(mass, size);