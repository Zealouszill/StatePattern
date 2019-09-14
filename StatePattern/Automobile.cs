// Author: Spencer Stewart
// Date: 9/14/2019
// Project: StatePattern

/* Description:
 * 
 * The class acts as the automobile, and will be able to change
 * states dependent upon it's functionality.
 * 
 */

using StatePattern.States;

namespace StatePattern
{
    class Automobile
    {
        // Create our four different potential states to switch between.
        private AutoMobileState isAccelerating;
        private AutoMobileState isBraking;
        private AutoMobileState isOff;
        private AutoMobileState isOn;

        // Create out state that will be "changing".
        private AutoMobileState automobileState;

        // Simple variables.
        private string carModel;
        private string owner;

        // Constructor for the class.
        public Automobile(string model, string newOwner)
        {
            // Instantiate our states using this current model.
            isAccelerating = new AcceleratingState(this);
            isBraking = new BrakingState(this);
            isOff = new PoweredDownState(this);
            isOn = new PoweredOnState(this);

            // Start what the initial state is.
            automobileState = isOff;

            // Car Model and owner assigned.
            carModel = model;
            owner = newOwner;
        }

        // Whenever we want to change the state of the automobile, we use this.
        public AutoMobileState SetAutomobileState
        {
            get { return automobileState; }
            set { automobileState = value; }
        }

        // Function to push the brake pedal, independent of what state we are in.
        public void PushBrakePedal()
        {
            SetAutomobileState.PushBrakePedal();
        }

        // Function to push the gas pedal, independent of what state we are in.
        public void PushGasPedal()
        {
            SetAutomobileState.PushGasPedal();
        }

        // Function to turn the car off, independent of what state we are in.
        public void TurnKeyOff()
        {
            SetAutomobileState.TurnKeyOff();
        }

        // Function to turn the car on, independent of what state we are in.
        public void TurnKeyOn()
        {
            SetAutomobileState.TurnKeyOn();
        }

        // Functions to get the state from other states.
        public AutoMobileState getAcceleratingState() { return isAccelerating; }
        public AutoMobileState getBrakinngState() { return isBraking; }
        public AutoMobileState getIsOffState() { return isOff; }
        public AutoMobileState getIsOnState() { return isOn; }
    }
}
