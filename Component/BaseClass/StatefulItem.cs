using System;
namespace CircuitRunner {

    public class StatefulItem : Item, IStatefulItem
    {
        private bool _state, _verbose;

        public bool State
        {
            get => _state; 
            set => _state = value;
        }
        public bool Verbose
        {
            get => _verbose; 
            set => _verbose = value;
        }
    }
}