using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    class PoweredOnState : AutoMobileState
    {
        Automobile TheAutoMobile;

        public PoweredOnState(Automobile newAutoMobileState)
        {
            TheAutoMobile = newAutoMobileState;
        }
        public override void PushBreakPedal()
        {
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getBrakinngState();
            Console.WriteLine("The car is breaking.");
        }

        public override void PushGasPedal()
        {
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getAcceleratingState();
            Console.WriteLine("The car is accelerating.");
        }

        public override void TurnKeyOff()
        {
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getIsOffState();
            Console.WriteLine("The car has been turned off.");
        }

        public override void TurnKeyOn()
        {
            Console.WriteLine("The car is already turned on.");
        }
    }
}
