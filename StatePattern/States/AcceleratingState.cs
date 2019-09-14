// Author: Spencer Stewart
// Date: 9/14/2019
// Project: StatePattern

/* Description:
 * 
 * Accelerating State. This state is set whenever the gas pedal function is called.
 * 
 */

using System;

namespace StatePattern.States
{
    class AcceleratingState : AutoMobileState
    {
        // Create our Automobile state for the class.
        Automobile TheAutoMobile;

        // Set the state was the class is created.
        public AcceleratingState(Automobile newAutoMobileState)
        {
            TheAutoMobile = newAutoMobileState;
        }

        // Change state to BrakingState if this function is called.
        public override void PushBrakePedal()
        {
            Console.WriteLine("The car is braking.");
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getBrakinngState();
        }

        // If this function is called, alert user that we are already in this class.
        public override void PushGasPedal()
        {
            Console.WriteLine("The car is already accelerating.");
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