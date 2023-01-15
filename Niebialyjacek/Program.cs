using System;

class Blackjack
{
    static void Main(string[] args)
    {
        int[] deck = new int[52];
        for (int i = 0; i < deck.Length; i++)
        {
            deck[i] = i;
        }

     
        Random rng = new Random();
        for (int i = 0; i < deck.Length; i++)
        {
            int j = rng.Next(deck.Length);
            int temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }

       
        int playerTotal = deck[0] % 13 + 1 + deck[1] % 13 + 1;
        Console.WriteLine("twoje karty: " + (deck[0] % 13 + 1) + " i " + (deck[1] % 13 + 1));
        Console.WriteLine("suma karty: " + playerTotal);

        
        int dealerTotal = deck[2] % 13 + 1 + deck[3] % 13 + 1;
        Console.WriteLine("karty oponenta: " + (deck[2] % 13 + 1) + " i " + (deck[3] % 13 + 1));
      
        while (true)
        {
            Console.WriteLine("dobierasz czy pasujesz?");
            string input = Console.ReadLine();
            if (input == "dobierz")
            {
                playerTotal += deck[4] % 13 + 1;
                Console.WriteLine("Twoje karty: " + (deck[0] % 13 + 1) 
                    + " i " + (deck[1] % 13 + 1) + " i " + (deck[4] % 13 + 1));
                Console.WriteLine("Suma: " + playerTotal);
            }
            else if (input == "pas")
            {
                break;
            }
            else
            {
                Console.WriteLine("wpisz DOBIERZ lub PAS.");
            }
        }

        // Determine the winner
        if (playerTotal > 21)
        {
            Console.WriteLine("Porażka!.");
        }
        else if (dealerTotal > 21 || playerTotal > dealerTotal)
        {
            Console.WriteLine("Zwycięstwo!");
        }
        else
        {
            Console.WriteLine("Remis.");
        }
    }
}