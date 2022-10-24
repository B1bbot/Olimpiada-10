class Program
{
    static void Main(string[] args)
    {
        int A = getInt();
        int B = getInt();
        int C = getInt();
        int N = getInt();
        int pie = getInt();

        int[] pies = new int[] {A, B, C};
        
        long costs = (A + B + C) * (N / 3);

        int remaningDays = N % 3;
        if (remaningDays == 1)
        {
            costs += pies[pie - 1];
        }
        if (remaningDays == 2)
        {
            if (pie == 3)
            {
                costs += pies[0] + pies[2];
            }
            else
            {
                costs += pies[pie - 1] + pies[pie];
            }
        }

        print(costs);

        int getInt() => int.Parse(Console.ReadLine());
        long getLong() => long.Parse(Console.ReadLine());
        void print<T>(T argument) => Console.WriteLine(argument);
    }
}