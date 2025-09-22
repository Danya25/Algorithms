namespace ConsoleApp1;

public static class Fibonacci
{
    public static int FibonaciRec(int a, int b, int limit)
    {
        var res = a + b;
        if (limit == 0) return res;
        Console.WriteLine(res);
        return FibonaciRec(b, a + b, --limit);
    }

    public static int FibonaciFor(int a, int b, int limit)
    {
        for (int i = 0; i < limit; i++)
        {
            var res = a + b;
            a = b;
            b = res;
            Console.WriteLine(res);
        }

        return 0;
    }
}