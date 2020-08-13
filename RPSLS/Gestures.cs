using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gestures
    {
        //member variables
        public List<string> gestureOptions;

        //constructor
        public Gestures()
        {
            List<string> gestureOptions = new List<string>();
            gestureOptions.Add("Rock");
            gestureOptions.Add("Paper");
            gestureOptions.Add("Scissors");
            gestureOptions.Add("Lizard");
            gestureOptions.Add("Spock");
        }

        //member methods
    }
}
