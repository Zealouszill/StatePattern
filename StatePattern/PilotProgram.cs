using System;

namespace StatePattern
{
    class PilotProgram
    {
        static void Main(string[] args)
        {
            Automobile HondaAccord = new Automobile("Accord", "Spencer");

            HondaAccord.PushBreakPedal();

            HondaAccord.TurnKeyOn();

            HondaAccord.PushBreakPedal();

            HondaAccord.PushGasPedal();
        }
    }
}