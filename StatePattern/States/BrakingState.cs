using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class BrakingState : AutoMobileState
    {
        Automobile TheAutoMobile;

        public BrakingState(Automobile newAutoMobileState)
        {
            TheAutoMobile = newAutoMobileState;
        }
        public override void PushBreakPedal()
        {
            Console.WriteLine("Brake pedal is already pressed.");
        }

        public override void PushGasPedal()
        {
            Console.WriteLine("The car is accelerating.");
            TheAutoMobile.SetAutomobileState = TheAutoMobile.getAcceleratingState();
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
