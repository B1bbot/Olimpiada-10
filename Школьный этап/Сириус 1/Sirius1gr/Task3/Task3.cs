class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> bars = new List<int>();

        for(int i = 0; i < n; i++)
        {
            bars.Add(int.Parse(Console.ReadLine()));
        }

        int equalSides = 0, triangels = 0;
        int currentSize = 0, previousSize = 0;

        for(int i = 0; i < n; i++)
        {
            currentSize = bars[i];
            if (currentSize > previousSize)
            {
                equalSides = 0;
            }
            equalSides++;
            if (equalSides == 3)
            {
                equalSides = 0;
                triangels++;
            }
            previousSize = currentSize;
        }

        Console.WriteLine(triangels);
    }
}