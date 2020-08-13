using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class GameMode
    {
        //member variables
        public double playerOneScore;
        public double playerTwoScore;
        Gestures gestures = new Gestures();


        //constructor 
        public GameMode()
        {

        }
        //member methods
        public void DisplayGestureOptions()
        {
            foreach(string option in gestures.gestureOptions)
            {
                Console.WriteLine(option);
            }
        }
        

        
    }
}
