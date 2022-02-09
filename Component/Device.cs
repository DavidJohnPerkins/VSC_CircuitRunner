using System;
namespace CircuitRunner
{
    public class Device : Item
    {
        public CollectionBase<Input> Inputs
        {
            get;
            //private set;
        }

        public CollectionBase<Circuit> Circuits
        {
            get;
            private set;
        }

        public CollectionBase<Output> Outputs
        {
            get;
            private set;
        }

        public Device()
        {
            Inputs = new CollectionBase<Input>();
            Circuits = new CollectionBase<Circuit>();
            Outputs = new CollectionBase<Output>();
        }

        public void AddInput(Input input)
        {
            Console.WriteLine("Adding input: {0}", input.Id);
            Inputs.Add(input);
        }

        public void AddOutput(Output output)
        {
            Console.WriteLine("Adding output: {0}", output.Id);
            Outputs.Add(output);
        }

        void AddGate(string id, Gate gate)
        {
            if (gate == null)
                throw new InvalidOperationException(
                    String.Format("Build: Error - gate {0} could not be added to circuit {1} - gate {2} does not exist", id, Id, gate.Id));
                    
            //inputNode.StateChanged -= HandleStateChange;
            //inputNode.StateChanged += HandleStateChange;
        }

        public void SetInput(string switchId, bool value)
        {
            var input = Inputs.Find(n => n.Id == switchId);
            if (input == null) {
                throw new InvalidOperationException(String.Format("Error: Cannot set switch {0} - it does not exist", switchId));
            }

            input.State = value;
        }
    }
}