int[] num = { 10, 5, 15, 7 };

obliczenia(num[0], num[1]);
obliczenia(num[2], num[3]);

int obliczenia(int liczba1, int liczba2)
{
    int sum = liczba1 + liczba2;
    Console.WriteLine("Suma: " + sum);

    int difference = liczba1 - liczba2;
    Console.WriteLine("Różnica: " + difference);

    int product = liczba1 * liczba2;
    Console.WriteLine("Iloczyn: " + product);

    int quotient = liczba1 / liczba2;
    Console.WriteLine("Iloraz: " + quotient);
}