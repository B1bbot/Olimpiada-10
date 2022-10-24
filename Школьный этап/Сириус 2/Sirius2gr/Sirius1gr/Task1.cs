class Program
{
    static void Main(string[] args)
    {
        int N = getInt();
        int K = getInt();
        int glue = 0;

        int partsOutside, partsInside;

        partsOutside = (N / K) * 4 - 4;
        partsInside = N * N / (K * K) - partsOutside;

        glue = ((partsOutside * 3 - 4) + partsInside * 4) / 2;
        Console.WriteLine(glue);
        
        int getInt() =>
            int.Parse(Console.ReadLine());
    }
}