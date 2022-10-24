class Program
{
    static void Main(string[] args)
    {
        long x = long.Parse(Console.ReadLine());
        long y = long.Parse(Console.ReadLine());

        if (x == y)
        {
            Console.WriteLine(-1);
            return;
        }

        long N = 0;
        long difference = y - x;
        long differencesSum = 0;
        while (true)
        {
            N += x;
            differencesSum += difference;
            if (differencesSum >= x - 1)
            {
                break;
            }
        }

        Console.WriteLine(N);


        int getInt() =>
            int.Parse(Console.ReadLine());
    }
}