int[] arg = { 1, 2, 3, 4, 5 };

int wynik = 0;
for (int i = 0; i < arg.Length; i++)
{
    wynik += arg[i];
}

Console.WriteLine(wynik);