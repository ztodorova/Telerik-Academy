//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrintDeckOf52cards
{
    static void Main()
    {
        string spades = "spades";
        string clubs = "clubs";
        string hearts = "hearts";
        string diamonds = "diamonds";

        for (int i = 2; i < 15; i++)
        {
            for (int suite = 1; suite < 5; suite++)
            {
                switch (i)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        Console.Write(" {0} ", i);
                        break;
                    case 11: Console.Write(" J ");
                        break;
                    case 12:
                        Console.Write(" Q ");
                        break;
                    case 13:
                        Console.Write(" K ");
                        break;
                    case 14:
                        Console.Write(" A ");
                        break;
                    default: Console.WriteLine("Invalid card");
                        break;
                }

                switch(suite)
                {
                    case 1:
                        Console.Write("of {0},", spades);
                        break;
                    case 2:
                        Console.Write("of {0},", hearts);
                        break;
                    case 3:
                        Console.Write("of {0},", clubs);
                        break;
                    case 4:
                        Console.Write("of {0}", diamonds);
                        break;
                    default:
                        Console.Write("Invalid suite");
                        break;
                }
           }
            Console.WriteLine();
        }
    }
}

