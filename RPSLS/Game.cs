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
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS!\n\n" +
                "For those concerned about the classic version's limited number of outcomes, we suggest...\n\n" +
                "       Rock, Paper, Scissors, Lizard, Spock.\n\n" +
                "It's very simple. Here are the rules:\n\n" +
                "Rock crushes Scissors\n" +
                "Scissors cuts Paper\n" +
                "Paper covers Rock\n" +
                "Rock crushes Lizard\n" +
                "Lizard poisons Spock\n" +
                "Spock smashes Scissors\n" +
                "Scissors decapitates Lizard\n" +
                "Lizard eats Paper\n" +
                "Paper disproves Spock\n" +
                "Spock vaporizes Rock\n\n" +
                "You can play against the computer in 1 player mode, or against a friend in 2 player mode\n" +
                "Choose Rock, Paper, Scissors, Lizard or Spock and hope your choice beats your opponent's\n" +
                "The best out of 3 wins.  Ready?    ...press enter to begin");Console.ReadLine();
            //Console.SetCursorPosition(centerConsole, ); 
            //Rock crushes Scissors
            //    Scissors cuts Paper
            //    Paper covers Rock
            //    Rock crushes Lizard
            //    Lizard poisons Spock
            //    Spock smashes Scissors
            //    Scissors decapitates Lizard
            //    Lizard eats Paper
            //    Paper disproves Spock
            //    Spock vaporizes Rock

        }

        public int ChooseNumberOfHumanPlayers()
        {
            return 0;
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
        }
    }
}
