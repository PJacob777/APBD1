// See https://aka.ms/new-console-template for more information
int[] tab = { 1, 2, 3, 4 };
Console.WriteLine("Hello, World!,,");
Console.WriteLine(avg(tab));

static double avg(int[] tab)
{
    double suma = 0;
    foreach (var i in tab)
    {
        suma += i;
    }

    return suma / tab.Length;
}

static int max(int[] tab)
{
    int maxv = 0;
    foreach (int i in tab)
    {
        if (maxv < i)
            maxv = i;
    }

    return maxv;
}