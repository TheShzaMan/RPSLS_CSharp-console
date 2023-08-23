using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Human : Player
    {
        //member variables (has a)

        //constructor (builder/spawner)
        public Human(string name)
        {
            Name = name;
        }
        //methods (can doif
        public override int ChooseGesture()
        {
            int numberSelection = 0;
            Console.WriteLine("Enter your selection 1,2,3,4 or 5\n");
            DisplayGestureKey();
            while (numberSelection <= 0 || numberSelection > 5)
            {
                try
                {
                    numberSelection = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Invalid entry. \n" +
                        "Enter your selection 1,2,3,4 or 5\n");
                }
            }
            int gesturesIndex = numberSelection - 1;
            //ChosenGesture = Gestures[numberSelection - 1];
            //Console.WriteLine(ChosenGesture);
            return gesturesIndex;

        }
        public void DisplayGestureKey()
        {
            int gestureNumber = 1;
            for (int i = 0; i < Gestures.Count; i++)
            {
                Console.Write($"\n({gestureNumber}) for {Gestures[i]}\n");
                gestureNumber++;
            }

        }
    }
}
