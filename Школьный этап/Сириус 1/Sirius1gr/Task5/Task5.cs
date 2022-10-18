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

            while(n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else if (n % 5 == 0)
                {
                    n /= 5;
                }
                else if (n % 3 == 0)
                {
                    n /= 3;
                }
                else
                {
                    return false;
                }
            }

            return true;
        } 
    }
}