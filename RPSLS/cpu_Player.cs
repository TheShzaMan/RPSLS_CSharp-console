using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Cpu : Player
    {
        //member variables (has a)
        public Random RndmGesture;
        //constructor (builder/spawner)
        public Cpu(string name)
        {
            Name = name;
            RndmGesture = new Random();
        }
        //methods (can do

        public override int ChooseGesture()
        {
            
            Console.WriteLine("Cpu player 2 is ready");
            int gesturesIndex = RndmGesture.Next(5);
            //ChosenGesture = Gestures[RndmGesture.Next(Gestures.Count)];
            //Console.WriteLine(ChosenGesture);
            return gesturesIndex;
        }
    }
}
