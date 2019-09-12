using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.States
{
    class PoweredDownState : Automobile
    {
        public override void PushBreakPedal(bool value)
        {
            throw new NotImplementedException();
        }

        public override void PushGasPedal(bool value)
        {
            throw new NotImplementedException();
        }

        public override void StateChangeCheck()
        {
            throw new NotImplementedException();
        }

        public override void TurnKeyOff(bool value)
        {
            throw new NotImplementedException();
        }
    }
}
