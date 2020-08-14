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
        public bool beatsRock;
        public bool beatsScissors;
        public bool beatsPaper;
        public bool beatsLizard;
        public bool beatsSpock;


        // constructor
        public Gestures(bool beatsRock, bool beatsScissors, bool beatsPaper, bool beatsLizard, bool beatsSpock)
        {
            this.beatsRock = beatsRock;
            this.beatsScissors = beatsScissors;
            this.beatsPaper = beatsPaper;
            this.beatsLizard = beatsLizard;
            this.beatsSpock = beatsSpock;

        }


    }
}
