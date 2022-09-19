class Task1
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int lenghtToNextStop = ((n / k) * k + k) - n;
        Console.WriteLine(Math.Min(n % k, lenghtToNextStop));
    }
}