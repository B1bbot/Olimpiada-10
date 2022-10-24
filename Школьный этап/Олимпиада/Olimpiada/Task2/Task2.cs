class Program
{
    static void Main(string[] args)
    {


        int getInt() => int.Parse(Console.ReadLine());
        long getLong() => long.Parse(Console.ReadLine());
        void print<T>(T argument) => Console.WriteLine(argument);
    }
}