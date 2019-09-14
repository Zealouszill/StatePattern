// Author: Spencer Stewart
// Date: 9/14/2019
// Project: StatePattern

/* Description:
 * 
 * Braking State. This state is set whenever the brake pedal function is called.
 * 
 */

using System;

namespace StatePattern
{
    class BrakingState : AutoMobileState
    {
        // Create our Automobile state for the class.
        Automobile TheAutoMobile;

        // Set the state was the class is created.
        public BrakingState(Automobile newAutoMobileState)
        {
            TheAutoMobile = newAutoMobileState;
        }

        // If this function is called, alert user that we are already in this class.
        public override void PushBrakePedal()
        {
            Console.WriteLine("The car continues to break.");
        }

        // Change state to AcceleratingState if this function is called.
        public override void PushGasPedal()
        {
            Console.WriteLine("The car is accelerating.");
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getAcceleratingState();
        }

        // Change state to PoweredDownState if this function is called.
        public override void TurnKeyOff()
        {
            Console.WriteLine("The car has been turned off.");
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getIsOffState();
        }

        // Change state to PoweredOnState if this function is called.
        public override void TurnKeyOn()
        {
            Console.WriteLine("The car is already on.");
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getIsOnState();
        }
    }
}
