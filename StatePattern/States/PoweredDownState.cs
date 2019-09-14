// Author: Spencer Stewart
// Date: 9/14/2019
// Project: StatePattern

/* Description:
 * 
 * PoweredDownState. This state is set whenever the TurnKeyOff function is called.
 * 
 */

using System;

namespace StatePattern.States
{
    class PoweredDownState : AutoMobileState
    {
        // Create our Automobile state for the class.
        Automobile TheAutoMobile;

        // Set the state was the class is created.
        public PoweredDownState(Automobile newAutoMobileState)
        {
            TheAutoMobile = newAutoMobileState;
        }

        // If this function is called, alert user that car is off and this won't work.
        public override void PushBrakePedal()
        {
            Console.WriteLine("The car is turned off. Nothing happened.");
        }

        // If this function is called, alert user that car is off and this won't work.
        public override void PushGasPedal()
        {
            Console.WriteLine("The car is turned off. Nothing happened.");
        }

        // If this function is called, alert user that car is off and this won't work.
        public override void TurnKeyOff()
        {
            Console.WriteLine("The car is already turned off. Nothing happened.");
        }

        // Change state to BrakingState if this function is called.
        public override void TurnKeyOn()
        {
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getIsOnState();
            Console.WriteLine("The car has been turned on.");
        }
    }
}
