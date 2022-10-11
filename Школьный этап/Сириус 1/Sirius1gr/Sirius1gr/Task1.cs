class Program
{
    static void Main(string[] args)
    {
        int holidays = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());

        while (day != 1 && day != 7)
        {
            holidays--;
            day++;
        }

        if (holidays > 0)
        {
            Console.WriteLine(holidays / 7);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}