using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player PlayerOne;
        public Player PlayerTwo;
        public int PlayerCount;
        //Constructor
        public Game()
        {
           
            PlayerCount = 0;
            
        }

        //Member Methods (CAN DO)
        
        //As a developer, I want to complete the WelcomeMessage() method in the Game class
        //so that players will get a message informing them of the game’s rules(what beats what,
        //how many rounds will be played, etc)
        public void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string rPSLS = @" 
             __   ___  ___ _    ___ 
            | _ \| _ \/ __| |  / __|
            |   /|  _/\__ \ |__\__ \
            | | \| |  |   /\   |   /";

            Console.WriteLine("Welcome to...");
            
            Console.WriteLine(rPSLS);
            Console.WriteLine(
                "\n\nFor those concerned about the classic version's limited number of outcomes, we suggest...\n\n" +
                "     Rock, Paper, Scissors, Lizard, Spock.\n\n" +
                "It's very simple. Here are the rules:\n\n" +
                "\tRock crushes Scissors\n" +
                "\tScissors cuts Paper\n" +
                "\tPaper covers Rock\n" +
                "\tRock crushes Lizard\n" +
                "\tLizard poisons Spock\n" +
                "\tSpock smashes Scissors\n" +
                "\tScissors decapitates Lizard\n" +
                "\tLizard eats Paper\n" +
                "\tPaper disproves Spock\n" +
                "\tSpock vaporizes Rock\n\n" +
                "- Play against the computer in 1 player mode, or against a friend in 2 player mode\n\n" +
                "- Choose Rock, Paper, Scissors, Lizard or Spock \nand hope your choice beats your opponent's\n\n" +
                "- The best out of 3 wins.  Ready?   " +
                "\n ...press enter to begin"); Console.ReadLine(); 
            

        }
        // I want to complete the ChooseNumberOfHumanPlayers() method in the Game class so that the user
        // will be prompted to choose between 1 and 2 players, and have that integer value returned from the method.

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nPlease choose game mode:\n\n");
            int gameModeSelection = 0;
            //while (gameModeSelection != 1 && gameModeSelection != 2)
            //while (PlayerCount == 0)
            while (gameModeSelection <= 0 ||  gameModeSelection >= 3) 
            {
                try
                {
                    Console.WriteLine("\t(1) for single player vs computer, or\n\t(2) for player vs player");
                    //Console.ForegroundColor = ConsoleColor.Black;
                    gameModeSelection = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }   
                catch
                {
                    Console.WriteLine("Invalid entry. Enter '1' or '2' to select game mode\n");
                }

                if (gameModeSelection == 1)
                {
                    Console.WriteLine("\n Single player mode : Human vs Computer\n");
                    PlayerCount = 1;
                }
                else if (gameModeSelection == 2)
                {
                    Console.WriteLine("Two player mode : Human vs Human\n");
                    PlayerCount = 2;
                }
            }
            PlayerCount = gameModeSelection;
            return PlayerCount;
        }

        public void CreatePlayerObjects(int playerCount)
        {
            
            //PlayerOne.ChooseGesture();
            //Console.WriteLine(PlayerTwo.ChosenGesture);
            if (playerCount == 1)
            {
                PlayerOne = new Human("Player1");
                PlayerTwo = new Cpu("Computer");
                //intantiate one human player and one Cpu player
            }
            else
            {
                PlayerOne = new Human("Player1");
                PlayerTwo = new Human("Player2");
                //instantiate two human players
            }
        }

        public void CompareGestures(int p1GestI, int p2GestI)
        {
            Console.WriteLine("press enter");Console.ReadLine();

            Console.WriteLine($"\n One, Two, Three, Shoot!\n");
            if (p1GestI ==  p2GestI)
            {
                Console.WriteLine($"\nTie! Both threw {PlayerOne.Gestures[p1GestI]}\nNo points, shoot again");
                
            }
            if (p1GestI == 0 && p2GestI == 2) 
            { 
                Console.WriteLine($"{PlayerOne.Name}'s Rock crushes {PlayerTwo.Name}'s Scissors");
                PlayerOne.Score++;
            }
            if (p1GestI == 2 && p2GestI == 0)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Rock crushes {PlayerOne.Name}'s Scissors");
                PlayerTwo.Score++;
            }
            if (p1GestI == 2 && p2GestI == 1)
            { 
                Console.WriteLine($"{PlayerOne.Name}'s Scissors cut {PlayerTwo.Name}'s Paper");
                PlayerOne.Score++;
            }
            if (p1GestI == 1 && p2GestI == 2)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Scissors cut {PlayerOne.Name}'s Paper");
                PlayerTwo.Score++;
            }
            if (p1GestI == 1 && p2GestI == 0)
            {
                Console.WriteLine($"{PlayerOne.Name}'s Paper covers {PlayerTwo.Name}'s Rock");
                PlayerOne.Score++;
            }
            if (p2GestI == 1 && p1GestI == 0)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Paper covers {PlayerOne.Name}'s Rock");
                PlayerTwo.Score++;
            }
            if (p1GestI == 0 && p2GestI == 3)
            {
                Console.WriteLine($"{PlayerOne.Name}'s Rock crushes {PlayerTwo.Name}'s Lizard");
                PlayerOne.Score++;
            }
            if (p2GestI == 0 && p2GestI == 3)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Rock crushes {PlayerOne.Name}'s Lizard");
                PlayerTwo.Score++; 
            }
            if (p1GestI == 3 && p2GestI == 4)
            {
                Console.WriteLine($"{PlayerOne.Name}'s Lizard poisons {PlayerTwo.Name}'s Spock");
                PlayerOne.Score++;
            }
            if (p2GestI == 3 && p1GestI == 4)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Lizard poisons {PlayerOne.Name}'s Spock");
                PlayerTwo.Score++;
            }
            if (p1GestI == 4 && p2GestI == 2)
            {
                Console.WriteLine($"{PlayerOne.Name}'s Spock smashes {PlayerTwo.Name}'s Scissors");
                PlayerOne.Score++;
            }
            if (p2GestI == 4 && p1GestI == 2)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Spock smashes {PlayerOne.Name}'s Scissors");
                PlayerTwo.Score++;
            }
            if (p1GestI == 2 && p2GestI == 3)
            {
                Console.WriteLine($"{PlayerOne.Name}'s Scissors decapitates {PlayerTwo.Name}'s Lizard");
                PlayerOne.Score++;
            }
            if (p2GestI == 2 && p1GestI == 3)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Scissors decapitates {PlayerOne.Name}'s Lizard");
                PlayerTwo.Score++;
            }
            if (p1GestI == 3 && p2GestI == 1)
            {
                Console.WriteLine($"{PlayerOne.Name}'s Lizard eats {PlayerTwo.Name}'s Paper");
                PlayerOne.Score++;
            }
            if (p2GestI == 3 && p1GestI == 1)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Lizard eats {PlayerOne.Name}'s Paper");
                PlayerTwo.Score++;
            }
            if (p1GestI == 1 && p2GestI == 4)
            {
                Console.WriteLine($"{PlayerOne.Name}'s Paper disproves {PlayerTwo.Name}'s Spock");
                PlayerOne.Score++;
            }
            if (p2GestI == 1 && p1GestI == 4)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Paper disproves {PlayerOne.Name}'s Spock");
                PlayerTwo.Score++;
            }
            if (p1GestI == 4 && p2GestI == 0)
            {
                Console.WriteLine($"{PlayerOne.Name}'s Spock vaporizes {PlayerTwo.Name}'s Rock");
                PlayerOne.Score++;
            }
            if (p2GestI == 4 && p1GestI == 0)
            {
                Console.WriteLine($"{PlayerTwo.Name}'s Spock vaporizes {PlayerOne.Name}'s Rock");
                PlayerTwo.Score++;
            }
            Console.WriteLine($"\n{PlayerOne.Name}: {PlayerOne.Score} and {PlayerTwo.Name}: {PlayerTwo.Score}\n" +
                $"press enter\n\n");



        }

        public void DisplayGameWinner()
        {
            Console.WriteLine("That's the Game!\n");
            if (PlayerOne.Score > PlayerTwo.Score)
            {
                Console.WriteLine($"{PlayerOne.Name} WINS!!!");
            }
            else
            {
                Console.WriteLine($"{PlayerTwo.Name} WINS!!!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            int playerCount = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(playerCount);
            while (PlayerOne.Score < 2 && PlayerTwo.Score < 2)
            {
                int gestureIndexP1 = PlayerOne.ChooseGesture();
                int gestureIndexP2 = PlayerTwo.ChooseGesture();
                CompareGestures(gestureIndexP1, gestureIndexP2);
            }
            
            DisplayGameWinner();

        }
    }
}
