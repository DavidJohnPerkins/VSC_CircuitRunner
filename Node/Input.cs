using System;
namespace CircuitRunner
{
    public class Input : EventRaiser
    {
        public void SetState(bool newState)
        {
            if (newState != State) {
                RaiseNotification(newState);
                State = newState;
            }
        }
    }
}
