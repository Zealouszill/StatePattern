using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    abstract class Automobile
    {
        private bool brakePedalPressed;
        private bool gasPedalPressed;
        private bool keyTurnedOn;

        public void InitalizeClass()
        {
            brakePedalPressed = false;
            gasPedalPressed = false;
            keyTurnedOn = false;
        }

        public abstract void PushGasPedal(bool value);

        public abstract void PushBreakPedal(bool value);

        public abstract void TurnKeyOff(bool value);

        public abstract void StateChangeCheck();
    }
}
