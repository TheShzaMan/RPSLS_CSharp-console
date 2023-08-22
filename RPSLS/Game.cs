using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        
        //As a developer, I want to complete the WelcomeMessage() method in the Game class
        //so that players will get a message informing them of the game’s rules(what beats what,
        //how many rounds will be played, etc)
        public void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to RPSLS!\n\n" +
                "For those concerned about the classic version's limited number of outcomes, we suggest...\n\n" +
                "       Rock, Paper, Scissors, Lizard, Spock.\n\n" +
                "It's very simple. Here are the rules:\n\n" +
                "Rock crushes Scissors\n" +
                "\tScissors cuts Paper\n" +
                "\tPaper covers Rock\n" +
                "\tRock crushes Lizard\n" +
                "\tLizard poisons Spock\n" +
                "\tSpock smashes Scissors\n" +
                "\tScissors decapitates Lizard\n" +
                "\tLizard eats Paper\n" +
                "\tPaper disproves Spock\n" +
                "\tSpock vaporizes Rock\n\n" +
                "- Play against the computer in 1 player mode, or against a friend in 2 player mode\n" +
                "- Choose Rock, Paper, Scissors, Lizard or Spock and hope your choice beats your opponent's\n" +
                "- The best out of 3 wins.  Ready?    ...press enter to begin"); Console.ReadLine();
            
        }
        // I want to complete the ChooseNumberOfHumanPlayers() method in the Game class so that the user
        // will be prompted to choose between 1 and 2 players, and have that integer value returned from the method.

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nPlease choose game mode:\n\n");
            int gameModeSelection = 0;
            while (gameModeSelection != 1 && gameModeSelection != 2)
            {
                try
                {
                    Console.WriteLine("\t(1) for single player vs computer, or\n\t(2) for player vs player");
                    gameModeSelection = int.Parse(Console.ReadLine());
                }
                catch
                {
                    //Console.WriteLine("Invalid entry. Enter '1' or '2' to select game mode");
                }

                if (gameModeSelection == 1)
                {
                    Console.WriteLine("\n Single player mode : Human vs Computer");
                }
                else if (gameModeSelection == 2)
                {
                    Console.WriteLine("Two player mode : Human vs Human");
                }
                else
                {
                    Console.WriteLine("Invalid entry. Enter '1' or '2' to select game mode\n");
                }
            }
            return gameModeSelection;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
        }
    }
}
