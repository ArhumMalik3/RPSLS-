using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //member variables (HAS A)
        

        //constructor
        public Human()
        {
            
        }


        //member methods
        public override void ChooseGesture()
        {
            Console.WriteLine("These are all of the gestures to choose from: ");
            Console.WriteLine(" ");
            foreach(string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Please select your gesture for this round: ");

            string userChoice = Console.ReadLine();
            gestureChoice = userChoice.ToLower();
            //PlayerChoice(userChoice);
        }

        //public void PlayerChoice(string playerChoice)
        //{
        //    switch(playerChoice)
        //    {
        //        case "rock":
        //            gestureChoice = new Rock(); 
        //            break;
        //    }
        //}

    }
}
