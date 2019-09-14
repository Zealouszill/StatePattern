using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Text;


namespace StatePattern
{
    class Automobile
    {
        private AutoMobileState isAccelerating;
        private AutoMobileState isBraking;
        private AutoMobileState isOff;
        private AutoMobileState isOn;

        private AutoMobileState automobileState;

        private string carModel;
        private string owner;

        public Automobile(string model, string newOwner)
        {
            isAccelerating = new AcceleratingState(this);
            isBraking = new BrakingState(this);
            isOff = new PoweredDownState(this);
            isOn = new PoweredOnState(this);

            automobileState = isOff;

            carModel = model;
            owner = newOwner;
        }

        public AutoMobileState SetAutomobileState
        {
            get { return automobileState; }
            set { automobileState = value; }
        }

        public void PushBreakPedal()
        {
            SetAutomobileState.PushBreakPedal();
        }

        public void PushGasPedal()
        {
            SetAutomobileState.PushGasPedal();
        }

        public void TurnKeyOff()
        {
            SetAutomobileState.TurnKeyOff();
        }

        public void TurnKeyOn()
        {
            SetAutomobileState.TurnKeyOn();
        }

        public AutoMobileState getAcceleratingState() { return isAccelerating; }
        public AutoMobileState getBrakinngState() { return isBraking; }
        public AutoMobileState getIsOffState() { return isOff; }
        public AutoMobileState getIsOnState() { return isOn; }
    }
}
