class Program
{
    static void Main(string[] args)
    {
        int K = getInt();

        int startPlace = (K - 1) * 4 + 1;
        int endPlace = 44 + (11 - K) * 2 + 2;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(startPlace + i);
        }
        for (int i = 1; i >= 0; i--)
        {
            print(endPlace - i);
        }

        int getInt() => int.Parse(Console.ReadLine());
        long getLong() => long.Parse(Console.ReadLine());
        void print<T>(T argument) => Console.WriteLine(argument);
    }
}