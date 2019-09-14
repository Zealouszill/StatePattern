using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    class AcceleratingState : AutoMobileState
    {
        Automobile TheAutoMobile;

        public AcceleratingState(Automobile newAutoMobileState)
        {
            TheAutoMobile = newAutoMobileState;
        }
        public override void PushBreakPedal()
        {
            Console.WriteLine("The car is braking.");
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getBrakinngState();
        }

        public override void PushGasPedal()
        {
            Console.WriteLine("The car is already accelerating.");
        }

        public override void TurnKeyOff()
        {
            Console.WriteLine("The car has been turned off.");
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getIsOffState();
        }

        public override void TurnKeyOn()
        {
            Console.WriteLine("The car is already on.");
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getIsOnState();
        }
    }
}