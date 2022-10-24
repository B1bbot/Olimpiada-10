class Program
{
    static void Main(string[] args)
    {
        int N = getInt();
        int X = getInt();
        int index = X;

        List<int> steps = new List<int>();

        while (N != 1)
        {
            if (isEven(index))
            {
                steps.Add(1);
            }
            else
            {
                steps.Add(2);
            }

            if (isEven(N))
            {
                N /= 2;
            }
            else
            {
                if(steps.Last() == 1)
                {
                    N /= 2;
                }
                else
                {
                    N = N / 2 + 1;
                }
            }
            index = index / 2 + index % 2;
        }

        foreach (int step in steps)
        {
            print(step);
        }

        bool isEven(int n) => n % 2 == 0;
        int getInt() => int.Parse(Console.ReadLine());
        long getLong() => long.Parse(Console.ReadLine());
        void print<T>(T argument) => Console.WriteLine(argument);
    }
}