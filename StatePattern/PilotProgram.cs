// Author: Spencer Stewart
// Date: 9/14/2019
// Project: StatePattern

/* Description:
 * 
 * This class is our pilot program for our state pattern project.
 * The purpose of this class is to test the functionality of our project
 * to make sure it works properly.
 * 
 */

namespace StatePattern
{
    class PilotProgram
    {
        static void Main(string[] args)
        {
            // Create a new Automobile to test our functionality with.
            Automobile HondaAccord = new Automobile("Accord", "Spencer");

            // Different functions we want to try out.
            HondaAccord.PushBrakePedal();
            HondaAccord.TurnKeyOn();
            HondaAccord.PushBrakePedal();
            HondaAccord.PushGasPedal();
        }
    }
}