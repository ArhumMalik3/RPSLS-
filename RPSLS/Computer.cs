using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //member variables (HAS A)
        Random rand;

        //constructor
        public Computer()
        {
            rand = new Random();

        }


        //member methods
        public override void ChooseGesture()
        {
            int randomNumber = rand.Next(4);
            gestureChoice = gestures[randomNumber];
            Console.WriteLine(gestureChoice);
        }
    }
}
