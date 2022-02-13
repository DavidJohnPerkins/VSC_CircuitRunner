using System;
namespace CircuitRunner
{
    public abstract class Item
    {

        public virtual string Id
        {
            get;
            set;
        }
        public string ParentId
        {
            get; set;
        }

        public bool Equals(Item other)
        {
            throw new NotImplementedException();
        }

        public string EvaluationMode
        {
            get;
            set;
        }

        protected void LogMessage(string message, bool verbose)
        {
            if (verbose)
                Console.WriteLine(message);
        }
    }
}
