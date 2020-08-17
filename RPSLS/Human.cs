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
        string userChoice;
        

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

            userChoice = Console.ReadLine();
            gestureChoice = userChoice.ToLower();
            CatchingInvalidInput();
            //PlayerChoice(userChoice);
        }

        public void CatchingInvalidInput()
        {

            bool catchingInput = gestures.Contains(gestureChoice);
            while (catchingInput == false)
            {
                Console.WriteLine("Unfortunately this is not one of the options, please choose again: ");
                userChoice = Console.ReadLine();
                gestureChoice = userChoice.ToLower();
                catchingInput = gestures.Contains(gestureChoice);
            }
            
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
