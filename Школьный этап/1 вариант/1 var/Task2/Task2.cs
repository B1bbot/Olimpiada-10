class Task2
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        int moreABoxes = 0, moreBBoxes = 0;
        while (A > 0 && B > 0)
        {
            sort();
        }

        if (A == 0 && B == 0)
        {
            showInfo();
        }
        else
        {
            Console.WriteLine(-1);
        }

        void showInfo() => Console.WriteLine(string.Format("{0} {1}", moreABoxes, moreBBoxes));
        void sort()
        {
            if (A > B)
            {
                moreABoxes++;
                A -= 2;
                B--;
            }
            else
            {
                moreBBoxes++;
                B -= 2;
                A--;
            }
        }
    }
}