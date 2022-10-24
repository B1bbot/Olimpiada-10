class Program
{
    static void Main(string[] args)
    {
        List <char> alphabet = "abcdefghijklmnopqrstuvwxyz".ToList();

        int N = getInt();
        char[] name = Console.ReadLine().ToCharArray();
        int k = 0;

        for (int i = 0; i < N - 1; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (alphabet.IndexOf(name[i]) < alphabet.IndexOf(name[j]))
                {
                    k++;
                }
            }
        }

        print(k);

        int getInt() => int.Parse(Console.ReadLine());
        long getLong() => long.Parse(Console.ReadLine());
        void print<T>(T argument) => Console.WriteLine(argument);
    }
}