class Program
{
    static void Main(string[] args)
    {
        int N = getInt();
        int K = getInt();
        int[] H = new int[N];
        for (int i = 0; i < N; i++)
        {
            H[i] = getInt();
        }

        int L = 0;
        int spendedCharge = 0, minimalSpendedCharge = -1000000000;
        for (int i = 0; i + K < N; i++)
        {
            for(int j = i; j < K + i; j++) 
            {
                spendedCharge -= H[j + 1] - H[j];
            }
            if (minimalSpendedCharge < spendedCharge)
            {
                minimalSpendedCharge = spendedCharge;
                L = i + 1;
            }
            spendedCharge = 0;
        }

        print(L);

        int getInt() => int.Parse(Console.ReadLine());
        long getLong() => long.Parse(Console.ReadLine());
        void print<T>(T argument) => Console.WriteLine(argument);
    }
}