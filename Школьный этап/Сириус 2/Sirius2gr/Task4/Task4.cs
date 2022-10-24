class Program
{
    static void Main(string[] args)
    {
        int N = getInt();
        int D = getInt();
        int[] jumps = new int[N];
        for (int jump = 0; N > jump; jump++)
        {
            jumps[jump] = getInt();
        }

        int currentIndex = 0;
        while (true)
        {
            int possibleLians = jumps[currentIndex] / D;

            if (possibleLians <= 0)
            {
                break;
            }

            int maxWay = 0;
            int movingUp = 0;
            for (int i = 1; i <= possibleLians; i++)
            {
                int holder = jumps[currentIndex + i] + D * i;
                if (holder >= maxWay)
                {
                    maxWay = holder;
                    movingUp = i;
                }
            }

            currentIndex += movingUp;
        }

        Console.WriteLine(currentIndex + 1);

        int getInt() =>
            int.Parse(Console.ReadLine());
    }
}