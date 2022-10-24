class Program
{
    static void Main(string[] args)
    {
        long x = long.Parse(Console.ReadLine());
        long y = long.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());
        long jumps = 0;
        
        jumps += n / (y + x) * 2;
        n %= y + x;

        if (n == 0)
        {

        }
        else if (n < y)
        {
            n -= y;
            jumps++;
        }
        else
        { 
            while (n > y)
            {
                n -= x;
                jumps++;
            }
            n -= y;
            jumps++;
        }

        print(jumps);

        int getInt() => int.Parse(Console.ReadLine());

    }

    static void print<T>(T argument) => Console.WriteLine(argument);
}