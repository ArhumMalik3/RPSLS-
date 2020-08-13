using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GamePlay
    {
        //member variables (HAS A)
        public Player player1;
        public Player player2;


        //constructor
        public GamePlay()
        {
            player1 = new Human();
            
        }

        //member methods
        public void RunGame()
        {
            //intro:
            //Welcome message
            WelcomeToGame();
            //display rules of the game
            DisplayRulesOfGame();
            //have player choose game mode
            SelectGameMode();

            //gameplay: (while loop)
            //display gesture options to player 1
            //player 1 chooses gesture
            player1.ChooseGesture();
            //display gesture to player 2 if its a human
            //player 2 chooses gesture
            //compare gestures
            //winner gets a point
            //display winner and scoreboard
            // keep going until someone gets 2 points

            //end:
            //display winner of the game 


        }

        public void WelcomeToGame()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock!");
            Console.ReadLine();
        }
        public void DisplayRulesOfGame()
        {
            Console.WriteLine("The rules are simple. \n" +
                "Rock crushes Paper \n" +
                "Scissors cuts Paper \n" +
                "Paper covers Rock\n" +
                "Rock crushes Lizard\n" +
                "Lizard poisons Spock\n" +
                "Spock smashes Scissors\n" +
                "Scissors decapitates Lizard\n" +
                "Lizard eats Paper\n" +
                "Paper disproves Spock\n" +
                "Spock vaporizes Rock\n");
            Console.ReadLine();
        }
        public void SelectGameMode()
        {
            Console.WriteLine("Would you like to play Single Player Mode or Multiplayer Mode?\n" +
                "Type 1 for single player\n" +
                "Type 2 for multi player\n");
            string response = Console.ReadLine();
            if(response == "1")
            {
                player2 = new Computer();
            }
            else
            {
                player2 = new Human();
            }

        }

        //public void ChooseGesture()
        //{

        //}

        

        public void Scoreboard()
        {

        }

        public void DisplayWinner()
        {

        }
    }
}
