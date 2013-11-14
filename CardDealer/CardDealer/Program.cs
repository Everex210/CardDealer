using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Here I am creating a main method for Hal Gould's Final exam. */

            //Declare variables
            String sUserName = String.Empty;
            Random rnd = new Random();
            Int32 iCardRank = 0;
            Int32 iCardSuit = 0;

            //Greet the user and store their name
            Console.Write("Hello! Welcome to Vegas Card Dealer. What is your name? ");
            sUserName = Console.ReadLine();
            Console.WriteLine();

            //Pause with a message to hit enter to show the first card
            Pause("Ok, " + sUserName + ". Please hit enter to show the card.");

            //Randomly generate a number between 1-13 for iCardRank and randomly generate a number for iCardSuit between 1-4
            iCardRank = rnd.Next(1, 14);
            iCardSuit = rnd.Next(1, 5);

            //Show the user the card, using the ShowCard method
            ShowCard(iCardRank, iCardSuit);

            //Pause the program with a message to tell the user to hit enter to show another card
            Pause("Ok, " + sUserName + ". Please hit enter to show the next card.");

            //Randomly generate a number between 1-13 for iCardRank and randomly generate a number for iCardSuit between 1-4
            iCardRank = rnd.Next(1, 14);
            iCardSuit = rnd.Next(1, 5);

            //Show the user the card, using the ShowCard method
            ShowCard(iCardRank, iCardSuit);

            //Pause the program with a message to tell the user to hit enter to show another card
            Pause("Ok, " + sUserName + ". Please hit enter to show the next card.");

            //Randomly generate a number between 1-13 for iCardRank and randomly generate a number for iCardSuit between 1-4
            iCardRank = rnd.Next(1, 14);
            iCardSuit = rnd.Next(1, 5);

            //Show the user the card, using the ShowCard method
            ShowCard(iCardRank, iCardSuit);

            //Pause the program with a message to tell the user to hit enter to show another card
            Pause("Ok, " + sUserName + ". Please hit enter to show the next card.");

            //Randomly generate a number between 1-13 for iCardRank and randomly generate a number for iCardSuit between 1-4
            iCardRank = rnd.Next(1, 14);
            iCardSuit = rnd.Next(1, 5);

            //Show the user the card, using the ShowCard method
            ShowCard(iCardRank, iCardSuit);

            //Pause the program with a message to tell the user to hit enter to show another card
            Pause("Ok, " + sUserName + ". Please hit enter to show the next card.");

            //Randomly generate a number between 1-13 for iCardRank and randomly generate a number for iCardSuit between 1-4
            iCardRank = rnd.Next(1, 14);
            iCardSuit = rnd.Next(1, 5);

            //Show the user the card, using the ShowCard method
            ShowCard(iCardRank, iCardSuit);

            //Pause the program with a message to tell the user to hit enter to show end the program
            Pause("Ok, " + sUserName + ". Please hit enter to exit the program.");

        }

        //-------------------------------------- Do not change anything below this line! --------------------------------------
        static void Pause(String strMessage)
        {
            Console.WriteLine();
            Console.WriteLine(strMessage);
            Console.ReadLine();
        }
        static void ShowCard(Int32 iRank, Int32 iSuit)
        {
            Console.Clear();

            if ((iRank == 1) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Ace of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|A      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      A|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 2) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Two of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|2      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      2|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 3) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Three of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|3      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      3|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 4) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Four of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|4      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      4|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 5) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Five of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|5      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      5|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 6) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Six of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|6      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      6|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 7) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Seven of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|7      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      7|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 8) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Eight of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|8      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      8|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 9) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Nine of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|9      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      9|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 10) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Ten of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|10     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     10|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 11) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Jack of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|J      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      J|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 12) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("Queen of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|Q      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      Q|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 13) && (iSuit == 1))
            {
                Console.WriteLine();
                Console.WriteLine("King of Diamonds");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|K      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♦   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      K|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 1) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Ace of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|A      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      A|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 2) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Two of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|2      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      2|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 3) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Three of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|3      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      3|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 4) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Four of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|4      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      4|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 5) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Five of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|5      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      5|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 6) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Six of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|6      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      6|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 7) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Seven of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|7      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      7|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 8) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Eight of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|8      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      8|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 9) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Nine of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|9      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      9|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 10) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Ten of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|10     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     10|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 11) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Jack of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|J      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      J|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 12) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("Queen of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|Q      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      Q|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 13) && (iSuit == 2))
            {
                Console.WriteLine();
                Console.WriteLine("King of Hearts");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|K      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♥   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      K|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 1) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Ace of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|A      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      A|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 2) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Two of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|2      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      2|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 3) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Three of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|3      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      3|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 4) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Four of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|4      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      4|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 5) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Five of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|5      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      5|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 6) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Six of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|6      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      6|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 7) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Seven of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|7      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      7|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 8) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Eight of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|8      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      8|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 9) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Nine of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|9      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      9|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 10) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Ten of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|10     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     10|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 11) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Jack of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|J      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      J|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 12) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("Queen of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|Q      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      Q|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 13) && (iSuit == 3))
            {
                Console.WriteLine();
                Console.WriteLine("King of Clubs");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|K      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♣   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      K|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 1) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Ace of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|A      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      A|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 2) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Two of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|2      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      2|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 3) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Three of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|3      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      3|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 4) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Four of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|4      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      4|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 5) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Five of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|5      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      5|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 6) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Six of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|6      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      6|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 7) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Seven of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|7      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      7|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 8) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Eight of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|8      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      8|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 9) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Nine of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|9      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      9|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 10) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Ten of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|10     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     10|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 11) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Jack of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|J      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      J|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 12) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("Queen of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|Q      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      Q|");
                Console.WriteLine("|_______|");
            }
            if ((iRank == 13) && (iSuit == 4))
            {
                Console.WriteLine();
                Console.WriteLine("King of Spades");
                Console.WriteLine();
                Console.WriteLine(".-------.");
                Console.WriteLine("|K      |");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ♠   |");
                Console.WriteLine("|       |");
                Console.WriteLine("|      K|");
                Console.WriteLine("|_______|");
            }
        }
    }
}
