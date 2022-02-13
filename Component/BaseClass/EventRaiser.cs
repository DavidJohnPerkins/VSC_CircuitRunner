using System;

namespace CircuitRunner
{
    public class EventRaiser : StatefulItem
    {
        public event EventHandler<StateChangedEventArgs> StateChanged;

        protected void RaiseNotification(bool newState)
        {
            StateChangedEventArgs args = new StateChangedEventArgs { NotifierId = Id, NewState = newState };
            OnStateChanged(args);
        }

        private void OnStateChanged(StateChangedEventArgs e)
        {
            LogMessage(String.Format("Event raised: Object {0} state --> {1}", e.NotifierId, e.NewState), Verbose);
            if (StateChanged != null)
            {
                StateChanged?.Invoke(this, e);
            }
            else
            {
                LogMessage(String.Format("Object {0} has no event handler", e.NotifierId), Verbose);
            }
        }
    }
}