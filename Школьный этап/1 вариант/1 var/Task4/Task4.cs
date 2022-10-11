class Task4
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        int verticle = 1;
        int horizontal = 1;
        int currentRange = 1;

        while (Math.Pow(currentRange, 2) < number)
        {
            currentRange++;
        }

        int comparedNumber = (int)(Math.Pow(currentRange - 1, 2) + 1);
        int directionRange = (int)((Math.Pow(currentRange, 2) - comparedNumber) / 2);
        if (number == 1)
        {
            Console.WriteLine("1 1");
        }
        else if (isEven(currentRange))
        {
            verticle = currentRange;

            compareByHorizontalsIncreasing();

            if(!TryFinish())
            {
                compareByVerticlesDecreasing();
                TryFinish();
            }
        }
        else
        {
            horizontal = currentRange;

            compareByVerticlesIncreasing();

            if (!TryFinish())
            {
                compareByHorizontalsDecreasing();
                TryFinish();
            }
        }

        void compareByHorizontalsIncreasing() 
        {
            while ((number != comparedNumber) && horizontal <= directionRange)
            {
                horizontal++;
                comparedNumber++;
            }
        }

        void compareByVerticlesDecreasing()
        {
            while (number != comparedNumber)
            {
                verticle--;
                comparedNumber++;
            }
        }

        void compareByVerticlesIncreasing()
        {
            while ((number != comparedNumber) && verticle <= directionRange)
            {
                verticle++;
                comparedNumber++;
            }
        }

        void compareByHorizontalsDecreasing()
        {
            while (number != comparedNumber)
            {
                horizontal--;
                comparedNumber++;
            }
        }

        bool TryFinish()
        {
            if (comparedNumber == number)
            {
                Console.WriteLine(String.Format("{0} {1}", horizontal, verticle));
                return true;
            }
            return false;
        }

        bool isEven(long number) => number % 2 == 0; 
    }
}