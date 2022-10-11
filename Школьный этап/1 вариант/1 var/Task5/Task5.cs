class Task5
{
    static void Main(string[] args)
    {
        int lenght = int.Parse(Console.ReadLine());
        int[] players = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            players[i] = int.Parse(Console.ReadLine());
        }

        int[] probabilities = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            probabilities[i] = 0;
        }

        for (int i = 0; i < lenght; i++)
        {
            int currentPlayer = players[i];

            List<int> playersCopy = new List<int>();
            for (int j = 0; j < lenght; j++)
            {
                playersCopy.Add(players[j]);
            }
            playersCopy.RemoveAt(i);

            for (int j = 0; j < playersCopy.Count; j++)
            {
                if (currentPlayer > playersCopy[j])
                {
                    currentPlayer += playersCopy[j];
                    playersCopy.RemoveAt(j);

                    if (playersCopy.Count > 0)
                    {
                        j = -1;
                    }
                    else
                    {
                        probabilities[i] = 1;
                    }
                }
            }
        }

        foreach (int probability in probabilities)
        {
            Console.WriteLine(probability);
        }
    }
}