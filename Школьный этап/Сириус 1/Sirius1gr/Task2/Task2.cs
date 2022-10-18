class Program
{
    static void Main(string[] args)
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int weight1 = 0, weight2 = 0;
        int weight1n1 = 0, weight1n2 = 0;

        while (n2 != 0)
        {
            if (weight1 < weight2)
            {
                weight1 += 2;
                weight1n2++;
                n2--;
            }
            else
            {
                weight2 += 2;
                n2--;
            }
        }

        while (n1 !=  0)
        {
            if (weight1 < weight2)
            {
                weight1++;
                weight1n1++;
                n1--;
            }
            else
            {
                weight2++;
                n1--;
            }
        }

        if (weight1 == weight2)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(String.Format("{0} {1}", weight1n1, weight1n2));
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}