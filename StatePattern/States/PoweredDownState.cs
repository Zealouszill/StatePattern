using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    class PoweredDownState : AutoMobileState
    {
        Automobile TheAutoMobile;

        public PoweredDownState(Automobile newAutoMobileState)
        {
            TheAutoMobile = newAutoMobileState;
        }
        public override void PushBreakPedal()
        {
            Console.WriteLine("The car is turned off. Nothing happened.");
        }

        public override void PushGasPedal()
        {
            Console.WriteLine("The car is turned off. Nothing happened.");
        }

        public override void TurnKeyOff()
        {
            Console.WriteLine("The car is already turned off. Nothing happened.");
        }

        public override void TurnKeyOn()
        {
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getIsOnState();
            Console.WriteLine("The car has been turned on.");
        }
    }
}
