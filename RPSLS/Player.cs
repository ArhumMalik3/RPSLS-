using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public double score;
        public List<string> gestures;


        //constructor 
        public Player()
        {
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }
        //member methods
        
        

        
    }
}
