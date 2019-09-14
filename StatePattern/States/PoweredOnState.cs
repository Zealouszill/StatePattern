// Author: Spencer Stewart
// Date: 9/14/2019
// Project: StatePattern

/* Description:
 * 
 * PoweredOnState. This state is set whenever the TurnKeyOn function is called.
 * 
 */

using System;

namespace StatePattern.States
{
    class PoweredOnState : AutoMobileState
    {
        // Create our Automobile state for the class.
        Automobile TheAutoMobile;

        // Set the state was the class is created.
        public PoweredOnState(Automobile newAutoMobileState)
        {
            TheAutoMobile = newAutoMobileState;
        }

        // Change state to BrakingState if this function is called.
        public override void PushBrakePedal()
        {
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getBrakinngState();
            Console.WriteLine("The car is breaking.");
        }

        // Change state to AcceleratingState if this function is called.
        public override void PushGasPedal()
        {
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getAcceleratingState();
            Console.WriteLine("The car is accelerating.");
        }

        // Change state to PoweredDownState if this function is called.
        public override void TurnKeyOff()
        {
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getIsOffState();
            Console.WriteLine("The car has been turned off.");
        }

        // If this function is called, alert user that we are already in this class.
        public override void TurnKeyOn()
        {
            Console.WriteLine("The car is already turned on.");
        }
    }
}
