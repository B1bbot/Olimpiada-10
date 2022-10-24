class Program
{
    static void Main(string[] args)
    {
        int s = getInt();
        int e = getInt();

        int N = getInt();
        int[] portals = new int[N];

        int wayToNearstPortal = 100000001;
        int wayFromPortalToOlimpiada = 100000001;
        for (int i = 0; i < N; i++)
        {
            portals[i] = getInt();

            int holder = Math.Abs(s - portals[i]);
            if (holder < wayToNearstPortal)
            {
                wayToNearstPortal = holder;
            }

            holder = Math.Abs(e - portals[i]);
            if (holder < wayFromPortalToOlimpiada)
            {
                wayFromPortalToOlimpiada = holder;
            }
        }

        int wayWithoutPortalsInSecs = Math.Abs(e - s);

        int wayWithPortalsInSecs = 0;
        wayWithPortalsInSecs = wayToNearstPortal + 1 + wayFromPortalToOlimpiada;

        Console.WriteLine(Math.Min(wayWithPortalsInSecs, wayWithoutPortalsInSecs));

        int getInt() =>
            int.Parse(Console.ReadLine());
    }
}