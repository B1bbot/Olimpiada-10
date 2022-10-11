class point 
{
    public int h, v;
}

class Task3
{
    static void Main(string[] args)
    {
        int N = GetInt();
        var rooks = new List<point>();
        var verticles = new List<int>();
        var horizontals = new List<int>();

        for (int i = 1; i <= N; i++)
        {
            point p = new point { h = i, v = GetInt() };  
            rooks.Add(p);
            horizontals.Add(p.h);
            verticles.Add(p.v);
        }

        horizontals.Reverse();
        for (int i = 0; i < rooks.Count; i++)
        {
            rooks[i].v = horizontals[i];
            rooks[i].h = verticles[i];
        }

        var turnedRooks = new point[rooks.Count];
        for (int i = 1; i <= rooks.Count; i++)
        {
            foreach (var rook in rooks)
            {
                if(rook.h == i)
                {
                    turnedRooks[i - 1] = rook;
                }
            }
        }

        foreach (var rook in turnedRooks)
        {
            Console.WriteLine(rook.v);
        }
    }

    private static int GetInt()
    {
        return int.Parse(Console.ReadLine());
    }
}