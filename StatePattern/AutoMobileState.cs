// Author: Spencer Stewart
// Date: 9/14/2019
// Project: StatePattern

/* Description:
 * 
 * Abstract class to be inherited by other sub state classes.
 * It contains the functions and 
 * 
 */

namespace StatePattern
{
    // Main Abstract state class.
    abstract class AutoMobileState
    {
        // Each function to be inherited and overridden in each class.
        public abstract void PushGasPedal();
        public abstract void PushBrakePedal();
        public abstract void TurnKeyOff();
        public abstract void TurnKeyOn();
    }
}
