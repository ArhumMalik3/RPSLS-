using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables (HAS A)
        public double score;
        public string gestureChoice;
        public List<string> gestures;


        //constructor 
        public Player()
        {
            score = 0;
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }
        //member methods

        public abstract void ChooseGesture();

        
    }
}
