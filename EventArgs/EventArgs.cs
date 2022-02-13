using System;
namespace CircuitRunner
{
    public class InputterEventArgs : EventArgs
    {
        //public ActionType ActionType { get; set; }
        public char InputChar { get; set; }
    }

    public class StateChangedEventArgs : EventArgs
    {
        public string NotifierId { get; set; }
        public bool NewState { get; set; }
    }
}
