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
            Intro();
            GameSequence();
            DisplayWinner();
        }

        public void Intro()
        {
            WelcomeToGame();
            DisplayRulesOfGame();
            SelectGameMode();
        }

        public void GameSequence()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                PlayersGestures();
                CompareGestures(player1.gestureChoice, player2.gestureChoice);
                Scoreboard();
            }
        }

        public void WelcomeToGame()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock!");
            Console.ReadLine();
        }
        public void DisplayRulesOfGame()
        {
            Console.WriteLine("The rules are simple. Each person selects their gesture and the best 2 out of 3 wins the game!\n" +
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
            Console.WriteLine(" ");
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
            Console.WriteLine(" ");
        }
        public void PlayersGestures()
        {
            player1.ChooseGesture();
            Console.Clear();
            
            player2.ChooseGesture();
            DisplayGestures();
        }

        public void DisplayGestures()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine($"Player 1 chose {player1.gestureChoice}.\n" +
                $"Player 2 chose {player2.gestureChoice}. ");
            Console.WriteLine(" ");
            Console.ReadLine();
        }

        

        public void CompareGestures(string player1Choice, string player2Choice)
        {
            if (player1Choice == player2Choice)
            {
                Console.WriteLine($"This round is a draw! Both players selected {player1Choice}!");
            }
            else if (player1Choice == "rock")
            {
                if (player2Choice == "paper")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, paper covers rock!"); 
                }
                else if(player2Choice == "scissors")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, rock crushes scissors!");
                }
                else if(player2Choice == "lizard")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, rock crushes lizard!");
                }
                else if(player2Choice == "spock")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, spock vaporizes rock!");
                }
                
            }
            else if (player1Choice == "paper")
            {
                if (player2Choice == "rock")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, paper covers rock!");
                }
                else if (player2Choice == "scissors")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, scissors cuts paper!");
                }
                else if (player2Choice == "lizard")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, lizard eats paper!");
                }
                else if (player2Choice == "spock")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, paper disproves spock!");
                }

            }
            else if (player1Choice == "scissors")
            {
                if (player2Choice == "rock")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, rock crushes scissors!");
                }
                else if (player2Choice == "paper")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, scissors cuts paper!");
                }
                else if (player2Choice == "lizard")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, scissors decapitates lizard!");
                }
                else if (player2Choice == "spock")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, spock smashes scissors!");
                }

            }
            else if (player1Choice == "lizard")
            {
                if (player2Choice == "rock")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, rock crushes lizard!");
                }
                else if (player2Choice == "paper")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, lizard eats paper!");
                }
                else if (player2Choice == "scissors")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, scissors decapitates lizard!");
                }
                else if (player2Choice == "spock")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, lizard poisons spock!");
                }

            }
            else if (player1Choice == "spock")
            {
                if (player2Choice == "rock")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, spock vaporizes rock!");
                }
                else if (player2Choice == "paper")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, paper disproves spock!");
                }
                else if (player2Choice == "scissors")
                {
                    player1.score++;
                    Console.WriteLine("Player 1 wins, spock smashes scissors!");
                }
                else if (player2Choice == "lizard")
                {
                    player2.score++;
                    Console.WriteLine("Player 2 wins, lizard poisons spock!");
                }
            }
           
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ReadLine();
        }

        

        public void Scoreboard()
        {
            Console.WriteLine("The score is:");
            Console.WriteLine(" ");
            Console.WriteLine($"Player 1: {player1.score}\n" +
                $"Player 2: {player2.score}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ReadLine();
        }

        public void DisplayWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine("Player 1 has won the game!");
            }
            else if (player2.score == 2)
            {
                Console.WriteLine("Player 2 has won the game!");
            }

        }
    }
}
