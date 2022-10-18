class Program
{
    struct point
    {
        public int x, y;

        public void Move(int hChange, int vChange)
        {
            x += hChange;
            y += vChange;
        }

        public override bool Equals(object? obj)
        {
            if (obj is point p)
            {
                return p.x == x && p.y == y;
            }
            return false;
        }
    }

    static void Main(string[] args)
    {
        point currentPoint = new point();
        point endPoint = new point();
        var way = new List<string>();

        currentPoint.y = getInt();
        currentPoint.x = getInt();
        endPoint.y = getInt();
        endPoint.x = getInt();

        if (isEven(currentPoint.x + currentPoint.y) != isEven(endPoint.x + endPoint.y))
        {
            Console.WriteLine("No");
            return;
        }

        go(ref currentPoint.x, ref currentPoint.y, endPoint.x);
        go(ref currentPoint.y, ref currentPoint.x, endPoint.y);

        Console.WriteLine("Yes");
        Console.WriteLine(way.Count);
        foreach(string p in way)
        {
            Console.WriteLine(p);
        }

        void go(ref int changed, ref int second, int comparable)
        {
            int direction;
            if (second == 8)
            {
                direction = -1;
            }
            else
            {
                direction = 1;
            }

            bool flag = false;
            while (changed != comparable)
            {
                if (changed > comparable)
                {
                    changed--;
                }
                else
                {
                    changed++;
                }
                if (!flag)
                {
                    second += 1 * direction;
                }
                else
                {
                    second += -1 * direction;
                }
                flag = !flag;
                way.Add(String.Format("{0} {1}", currentPoint.y, currentPoint.x));
            }
        }

        bool isEven(int n) => n % 2 == 0;

        int getInt() => int.Parse(Console.ReadLine());
    }
}