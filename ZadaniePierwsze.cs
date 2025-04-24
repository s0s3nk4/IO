int modulo(int number)
{
    int n;
    n = number % 2;
    return n;
}

int modulo5(int squaredNumber)
{
    int s;
    s = squaredNumber % 5;
    return s;
}

int[] numbers = { 5, 10, 15, 20, 25 };
foreach (int number in numbers)
{
    if (modulo(number) == 0)
    {
        int squaredNumber = number * number;
        if(modulo5(squaredNumber) == 0)
        {
            sum += squaredNumber;
        }
    }
}

Console.WriteLine("Suma kwadratow liczb parzystych podzielnych przez 5 jest rowna" + sum);