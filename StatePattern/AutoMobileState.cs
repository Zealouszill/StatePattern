using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    abstract class AutoMobileState
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

        public abstract void PushGasPedal();
        public abstract void PushBreakPedal();
        public abstract void TurnKeyOff();
        public abstract void TurnKeyOn();
    }
}
