class Program
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());

        long maxNumber = 0;
        for (long n = number; n >= 2; n--)
        {
            if (isInteresting(n))
            {
                maxNumber = n;
                break;
            }
        }

        Console.WriteLine(maxNumber);

        bool isInteresting(long n)
        {
            if (!(n % 2 == 0 || n % 3 == 0 || n % 5 == 0))
                return false;

            long border = (long)(Math.Round(n * 0.5 + 1));
            for (long i = 6; i <= border; i++)
            {
                if (isSimple(i))
                {
                    if (n % i == 0)
                        return false;
                }
            }

            return true;
        }
        
        bool isSimple(long n)
        {
            long border = (long)(Math.Round(n * 0.5 + 1));
            for (long i = 2; i < border; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}